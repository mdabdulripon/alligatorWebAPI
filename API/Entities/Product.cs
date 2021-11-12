using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; } // * We could use decimal or int
        public string PictureUrl { get; set; }
        public string ProductType { get; set; } // * type shirt, pants, glasses, 
        public string ProductCategory { get; set; } // * Brand, Man, women, Kids, Todlars, Teeneger, 
        public int QuantityInStock { get; set; }
        // sizes 
        // colors
        // pictures
        public string MerchantId { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } = DateTime.Now;
    }
}