using globa_bilgi_unit_test_sample.test.DependencyFixture;
using global_bilgi_unittest_sample.Controllers;
using global_bilgi_unittest_sample.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ControllerTests
{
    public class CategoryControllerTests : IClassFixture<DbFixture>
    {

        private ServiceProvider _serviceProvider;
        private CategoryController _categoryController;

        public CategoryControllerTests(DbFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
            _categoryController = new CategoryController(_serviceProvider.GetService<ICategoryRepository>());
            
        }


        [Fact]
        public void Index()
        {
            var result = _categoryController.Index();

            Assert.NotNull(result);
        }
        

    }
}
