using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    // * Static class does not need to be initialize  
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "Angular Speedster Board 2000",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 200,
                    PictureUrl = "/images/products/sb-ang1.png",
                    ProductCategory = "Angular",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "Green Angular Board 3000",
                    Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                    Price = 150,
                    PictureUrl = "/images/products/sb-ang2.png",
                    ProductCategory = "Angular",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "Core Board Speed Rush 3",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 180,
                    PictureUrl = "/images/products/sb-core1.png",
                    ProductCategory = "NetCore",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "Net Core Super Board",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 300,
                    PictureUrl = "/images/products/sb-core2.png",
                    ProductCategory = "NetCore",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "React Board Super Whizzy Fast",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 250,
                    PictureUrl = "/images/products/sb-react1.png",
                    ProductCategory = "React",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "ProductTypescript Entry Board",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 120,
                    PictureUrl = "/images/products/sb-ts1.png",
                    ProductCategory = "ProductTypeScript",
                    ProductType = "Boards",
                    QuantityInStock = 100,
                    MerchantId = "124125"
                },
                new Product
                {
                    Name = "Core Blue Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 10,
                    PictureUrl = "/images/products/hat-core1.png",
                    ProductCategory = "NetCore",
                    ProductType = "Hats",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Green React Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 80,
                    PictureUrl = "/images/products/hat-react1.png",
                    ProductCategory = "React",
                    ProductType = "Hats",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Purple React Woolen Hat",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15,
                    PictureUrl = "/images/products/hat-react2.png",
                    ProductCategory = "React",
                    ProductType = "Hats",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Blue Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 18,
                    PictureUrl = "/images/products/glove-code1.png",
                    ProductCategory = "VS Code",
                    ProductType = "Gloves",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Green Code Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 15,
                    PictureUrl = "/images/products/glove-code2.png",
                    ProductCategory = "VS Code",
                    ProductType = "Gloves",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Purple React Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 16,
                    PictureUrl = "/images/products/glove-react1.png",
                    ProductCategory = "React",
                    ProductType = "Gloves",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Green React Gloves",
                    Description =
                        "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 14,
                    PictureUrl = "/images/products/glove-react2.png",
                    ProductCategory = "React",
                    ProductType = "Gloves",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Redis Red Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 250,
                    PictureUrl = "/images/products/boot-redis1.png",
                    ProductCategory = "Redis",
                    ProductType = "Boots",
                    QuantityInStock = 100,
                    MerchantId = "115161"
                },
                new Product
                {
                    Name = "Core Red Boots",
                    Description =
                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                    Price = 189,
                    PictureUrl = "/images/products/boot-core2.png",
                    ProductCategory = "NetCore",
                    ProductType = "Boots",
                    QuantityInStock = 100,
                    MerchantId = "riyan-shop",
                },
                new Product
                {
                    Name = "Core Purple Boots",
                    Description =
                        "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                    Price = 199,
                    PictureUrl = "/images/products/boot-core1.png",
                    ProductCategory = "NetCore",
                    ProductType = "Boots",
                    QuantityInStock = 100,
                    MerchantId = "riyan-shop",
                },
                new Product
                {
                    Name = "Angular Purple Boots",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 150,
                    PictureUrl = "/images/products/boot-ang2.png",
                    ProductCategory = "Angular",
                    ProductType = "Boots",
                    QuantityInStock = 100,
                    MerchantId = "riyan-shop",
                },
                new Product
                {
                    Name = "Angular Blue Boots",
                    Description =
                        "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                    Price = 180,
                    PictureUrl = "/images/products/boot-ang1.png",
                    ProductCategory = "Angular",
                    ProductType = "Boots",
                    QuantityInStock = 100,
                    MerchantId = "riyan-shop",
                }
            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}
