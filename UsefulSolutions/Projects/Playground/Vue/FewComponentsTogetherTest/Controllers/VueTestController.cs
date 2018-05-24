using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet]
        public ActionResult GetProduct(int id)
        {
            var result = ProductsList.FirstOrDefault(x => x.id == id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public ActionResult AddProduct(Product product)
        //{
        //    product.id = new Random().Next(1000, 1000000);
        //    product.description += " - " + product.id;
        //    ProductsList.Add(product);

        //    return Json(true, JsonRequestBehavior.AllowGet);
        //}

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            ProductsList.RemoveAll(x => x.id == productId);

            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveProduct(Product product)
        {
            if (product.id > 0)
            {
                var editedProduct = ProductsList.FirstOrDefault(x => x.id == product.id);
                editedProduct.quantity = product.quantity;
                editedProduct.price = product.price;
                editedProduct.description = product.description;
            }
            else
            {
                product.id = new Random().Next(1000, 1000000);
                product.description += " - " + product.id;
                product.quantity = new Random().Next(1,10);
                product.price = new Random().Next(1, 4);
                ProductsList.Add(product);
            }


            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}