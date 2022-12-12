using Supply_chain_management_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Data.Entity;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace Supply_chain_management_WebApp.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private Model1 db = new Model1();
        private Model2 db2 = new Model2();
        public ActionResult Index()
        {
            return View();
        }
        private int isExist(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int item = 0; item < cart.Count; item++)
                if (cart[item].Pr.Id == id)
                    return item;
            return -1;
        }
        public ActionResult Buy(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(db.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExist(id);
                if(index == -1)
                    cart.Add(new Item(db.Products.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult CurrentCart()
        {
            List<Item> cart = (List<Item>)Session["cart"];
            Session["cart"] = cart;
            return View("Cart");
        }

        public ActionResult Remove(int id)
        {
            int index = isExist(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }
        public ActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOrder([Bind(Include = "AgentName,AgentNumber,AgentEmail,AgentAddress")]WebOrder item)
        {
            string name = item.AgentName;
            int number = item.AgentNumber;
            string email = item.AgentEmail;
            string address = item.AgentAddress;
            ViewBag.name = item.AgentName;
            ViewBag.number = item.AgentNumber;
            ViewBag.email = item.AgentEmail;
            ViewBag.address = item.AgentAddress;
            ViewBag.total = item.TotalPrice;
            if (ModelState.IsValid)
            {
                db2.WebOrders.Add(item);
                db2.SaveChanges();
            }
            Session.Clear();
            return RedirectToAction("Index", "Home", new { status = "orderSuccess"});
        }
    }
}