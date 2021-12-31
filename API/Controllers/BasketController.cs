using System;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly StoreContext _context;
        public BasketController(StoreContext context)
        {
            _context = context;
        }


        [HttpGet(Name = "GetBasket")]
        public async Task<ActionResult<BasketDto>> GetBasket()
        {
            var basket = await RetriveBasket();

            if (basket == null) return NotFound();
            return MapBasketToDto(basket);
        }

        // [HttpPost("{productId}/{quantity}")]
        [HttpPost]
        public async Task<ActionResult<BasketDto>> AddItemToBasket(int productId, int quantity)
        {
            // * get Basket || create Basket
            var basket = await RetriveBasket();

            if (basket == null)
            {
                basket = CreateNewBasket();
            }

            // * get Product
            var product = await _context.Products.FindAsync(productId);
            if (product == null) return BadRequest(new ProblemDetails { Title = "Product not found" });

            // * Add item 
            basket.AddItem(product, quantity);

            // * Save changes
            var result = await _context.SaveChangesAsync() > 0;

            if (result) return CreatedAtRoute("GetBasket", MapBasketToDto(basket));

            return BadRequest(new ProblemDetails { Title = "Problem with saving basket Item" });
        }

        // [HttpDelete("{productId}/{quantity}")]
        [HttpDelete]
        public async Task<ActionResult> RemoveBasketItem(int productId, int quantity)
        {
            // get Basket 
            var basket = await RetriveBasket();
            if (basket == null)
            {
                return NotFound();
            }

            // remove item or reduce the quantity 
            basket.RemoveItem(productId, quantity);

            // save changes
            var result = await _context.SaveChangesAsync() > 0;
            if (result) return Ok();

            return BadRequest(new ProblemDetails { Title = "Problem removing item from the basket" });
        }

        private async Task<Basket> RetriveBasket()
        {
            return await _context.Baskets
                            .Include(i => i.Items)
                            .ThenInclude(p => p.Product)
                            .FirstOrDefaultAsync(x => x.BuyerId == Request.Cookies["buyerId"]);
        }


        private Basket CreateNewBasket()
        {
            var buyerId = Guid.NewGuid().ToString();
            // Createing Cookies
            var cookieOptions = new CookieOptions { IsEssential = true, Expires = DateTime.Now.AddDays(3) };
            Response.Cookies.Append("buyerId", buyerId);

            // Initialize the Basket  
            var basket = new Basket { BuyerId = buyerId };
            _context.Baskets.Add(basket);

            return basket;
        }

        private BasketDto MapBasketToDto(Basket basket)
        {
            return new BasketDto
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(item => new BasketItemDto
                {
                    ProductId = item.ProductId,
                    Name = item.Product.Name,
                    Price = item.Product.Price,
                    PictureUrl = item.Product.PictureUrl,
                    ProductType = item.Product.ProductType,
                    ProductCategory = item.Product.ProductCategory,
                    Quantity = item.Quantity
                }).ToList()
            };
        }
    }
}