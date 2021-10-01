using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductVM> model = new List<ProductVM>();

            ProductVM product = new ProductVM();
            product.Id = 1;
            product.Title = "IPhone";
            product.Description = "Apple ürünü";


            ProductVM product2 = new ProductVM();
            product2.Id = 2;
            product2.Title = "Samsung";
            product2.Description = "Samsung ürünüdür. vesaire...";


            ProductVM product3 = new ProductVM();
            product3.Id = 3;
            product3.Title = "Oppo";
            product3.Description = "Oppo ürünü";

            model.Add(product);
            model.Add(product2);
            model.Add(product3);

            return View(model);
        }


        public IActionResult Delete(int id)
        {

            return RedirectToAction("Index", "Product");
        }
    }
}