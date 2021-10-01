using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.Models;
using global_bilgi_unittest_sample.Models.DISample;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Contact(ContactVM model)
        {
            //işlemler

            return View();
        }


        public bool StatusCheck(int age)
        {
            if(age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DateTime GetNextDay(DateTime dt)
        {
            return dt.AddDays(1);
        }
    }
}