using globa_bilgi_unit_test_sample.test.Helpers.DateCompreHelper;
using globa_bilgi_unit_test_sample.test.Helpers.Extensions;
using global_bilgi_unittest_sample.Controllers;
using global_bilgi_unittest_sample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ControllerTests
{
    public class HomeControllerTests
    {

        [Fact]
        public void Index()
        {
            var homeController = new HomeController();

            var result = homeController.Index();

            Assert.NotNull(result);

        }

        [Fact]
        public void ContactGet()
        {
            var homeController = new HomeController();

            var result = homeController.Contact() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
             
        }

        [Fact]
        public void ContactPost()
        {
            var homeController = new HomeController();

            var contactVM = new ContactVM();
            contactVM.Title = "Sipariş sorunu";
            contactVM.Message = "Siparişim elime ulaşmadı. Destek talep ediyorum";


            var result = homeController.Contact(contactVM);

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            //xunit, nunit ve msunit

        }


        [Theory]
        [InlineData(20)]
        [InlineData(14)]
        public void StatusCheck(int age)
        {
            var homeController = new HomeController();

            var result = homeController.StatusCheck(age);

            result.ShouldBeFalse();

        }


        [Fact]
        public void GetNextDay()
        {
            var homeController = new HomeController();

            var date = DateTime.Now;
            var result = homeController.GetNextDay(date);

            Assert.Equal(date, result, new DateAddDayComparer());
        }

    }
}
