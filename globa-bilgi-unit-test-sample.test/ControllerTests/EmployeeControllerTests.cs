using global_bilgi_unittest_sample.Controllers;
using global_bilgi_unittest_sample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ControllerTests
{
    public class EmployeeControllerTests
    {

        [Fact]
        public void Index()
        {
            var controller = new EmployeeController();

            var result = controller.Index() as ViewResult;

            var resultData = result.ViewData.Model as EmployeeVM;

            Assert.NotNull(result);

           
        }
        
    }
}
