using global_bilgi_unittest_sample.Controllers;
using global_bilgi_unittest_sample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ControllerTests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Index()
        {
            //1 => metot tamamlanıp bana viewresult dönmeli
            //2 => dönen model List<ProductVM> olmalı
            //3 => dönen model count > 2 olmalı

            var productController = new ProductController();
            var result = productController.Index() as ViewResult;

            Assert.NotNull(result);

            var resultData = result.ViewData.Model as List<ProductVM>;

            Assert.True(resultData.Count > 0);
            Assert.Equal(3, resultData.Count);


        }


        [Theory]
        [InlineData(0)]
        [InlineData(int.MaxValue)]
        [InlineData(int.MinValue)]
        public void Delete(int id)
        {
            var productController = new ProductController();

            var result = productController.Delete(id) as RedirectToActionResult;

            Assert.NotNull(result);
            Assert.Equal("Index", result.ActionName);
            Assert.Equal("Product", result.ControllerName);

        }
    }
}
