using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Supply_chain_management_WebApp.Models;
namespace Supply_chain_management_WebApp.Controllers
{
    public class Item
    {
        private Product pr = new Product();
        private int quantity;
        
        public Item() 
        { }

        public Item(Product product, int quantity)
        {
            this.Pr = product;
            this.Quantity = quantity;
        }
        public int Quantity { get => quantity; set => quantity = value; }
        public Product Pr { get => pr; set => pr = value; }
    }
}