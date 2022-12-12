using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Supply_chain_management_WebApp.Models
{
    public class CartItem
    {
        [Key]
        public string CartId { get; set; }

        public string ProductId { get; set; }


        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string AgentName { get; set; }

        public int AgentNumber { get; set; }

        public string AgentEmail { get; set; }

        public string AgentAddress { get; set; }

        public decimal TotalPrice { get; set; }



        public System.DateTime DateCreated { get; set; }
    }
}