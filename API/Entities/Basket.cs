using System.Collections.Generic;
using System.Linq;

namespace API.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        /**
        * * one to many relationship
        * ! One basket have many basket item
        **/ 
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();


        public void AddItem(Product product, int quantity)
        {
            if (Items.All(item => item.ProductId != product.Id))
            {
                Items.Add(new BasketItem { Product = product, Quantity = quantity });
            }
            var existingItem = Items.FirstOrDefault(item => item.ProductId == product.Id);
            if (existingItem != null) existingItem.Quantity += quantity;
        }


        public void RemoveItem(int productId, int quantity)
        {
            var cartItem = Items.FirstOrDefault(item => item.ProductId == productId);
            if (cartItem == null) return;
            cartItem.Quantity -= quantity;
            if (cartItem.Quantity == 0) Items.Remove(cartItem);
        }
    }
}