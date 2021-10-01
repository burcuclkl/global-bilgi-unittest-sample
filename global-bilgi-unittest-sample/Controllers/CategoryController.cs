using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;


        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            List<Category> categories = _categoryRepository.GetAll();

            return View(categories);
        }
    }
}