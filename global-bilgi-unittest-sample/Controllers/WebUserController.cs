using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace global_bilgi_unittest_sample.Controllers
{
    public class WebUserController : Controller
    {

        private readonly IWebUserRepository _webUserRepository;

        public WebUserController(IWebUserRepository webUserRepository)
        {
            _webUserRepository = webUserRepository;
        }

        public IActionResult Index()
        {
            List<WebUser> webUsers = _webUserRepository.GetAll();

            var count = webUsers.Count;

            //gelen data üzerinde kimi işlemler yapılıyor...

            return View(webUsers);
        }

        public IActionResult GetWebUserById(int id)
        {

            WebUser webuser = _webUserRepository.GetWebUserById(id);

            return View(webuser);
        }
    }
}