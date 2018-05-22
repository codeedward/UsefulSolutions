using System;
using System.Collections.Generic;
using System.Web.Mvc;
using FewComponentsTogetherTest.Models;

namespace FewComponentsTogetherTest.Controllers
{
    public class VueTestController : Controller
    {
        public static List<Product> ProductsList = new List<Product>()
        {
            new Product()
            {
                id = 1,
                description = "eggs",
                quantity = 1,
                price = 2
            },
            new Product()
            {
                id = 2,
                description = "cashews",
                quantity = 2,
                price = 10
            }
        };
        // GET: VueTest
        [HttpGet]
        public ActionResult GetProducts()
        {
            return Json(ProductsList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            product.id = new Random().Next(1000, 1000000);
            product.description += " - " + product.id;
            ProductsList.Add(product);

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            ProductsList.RemoveAll(x => x.id == productId);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}