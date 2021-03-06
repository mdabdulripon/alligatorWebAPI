using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using API.Extensions;
using API.RequestHelpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<Product>>> GetProducts([FromQuery] ProductParams productParams)
        {
            var query = _context.Products
                .Sort(productParams.orderBy)
                .Search(productParams.searchTerm)
                .Filter(productParams.categories, productParams.types)
                .AsQueryable();

            var products = await PagedList<Product>.ToPagedList(query, productParams.PageNumber, productParams.PageSize);
            Response.AddPaginationHeader(products.MetaData);

            return products;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            return product;
        }


        [HttpGet("filters")]
        public async Task<IActionResult> GEtFilters()
        {
            var categories = await _context.Products.Select(c => c.ProductCategory).Distinct().ToListAsync();
            var types = await _context.Products.Select(c => c.ProductType).Distinct().ToListAsync();
            return Ok(new { categories, types });
        }

    }
}
