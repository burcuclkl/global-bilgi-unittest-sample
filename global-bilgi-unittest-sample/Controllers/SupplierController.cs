using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.Models.DISample;
using global_bilgi_unittest_sample.Models.DISample2;
using global_bilgi_unittest_sample.Models.StateDesingPattern;
using global_bilgi_unittest_sample.Models.TemplateMethodDesignPattern;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class SupplierController : Controller
    {



        public IActionResult Index()
        {
            Supplier supplier = new Supplier();
            supplier.CompanyName = "Apple";
            supplier.ContactName = "Steve Jobs";

            ILogger logger = new XMLLogger();

            SupplierManager supplierManager = new SupplierManager(logger);

            supplierManager.AddSupplier(supplier);
            return View();
        }


        public IActionResult DashboardInit()
        {
            Dashboard dashboard = new Dashboard(new Admin());

            dashboard.Init();

            return View();
        }

        public void AsistanPage()
        {
            Asistan asistan = new Asistan();

            asistan.Answer();

            asistan.ChangeMode(new GeceMode());


            asistan.Answer();

        }

        public void RaporPage()
        {
            SistemRaporlama sistemRaporlama = null;

            sistemRaporlama = new XMLRapor();
            sistemRaporlama.RaporYaz();

            sistemRaporlama = new ExcelRapor();
            sistemRaporlama.RaporYaz();



        }



    }
}