using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.Models;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            //business daha sonra yazılıyor
            
            return View(new EmployeeVM());
        }
    }
}