using globa_bilgi_unit_test_sample.test.DependencyFixture;
using global_bilgi_unittest_sample.ORM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Xsl;
using Xunit;

namespace globa_bilgi_unit_test_sample.test.ContextTests
{
    public class GlobalBilgiContextTests : IClassFixture<DbFixture>
    {
        ServiceProvider _serviceProvider;

        public GlobalBilgiContextTests(DbFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
        }


        [Fact]
        public void CategoriesListTest()
        {
            var options = new DbContextOptionsBuilder<GlobalBilgiContext>().UseSqlServer("Server=DESKTOP-J7RNMCU; Database=GlobalDb; Trusted_Connection =true").Options;

            using (var context = new GlobalBilgiContext(options))
            {
                var data = context.Categories.ToList();
            }
        }

        [Fact]
        public void CategoryInsertTest()
        {
            var options = new DbContextOptionsBuilder<GlobalBilgiContext>().UseInMemoryDatabase(databaseName: "GlobalBilgi").Options;

            using (var context = new GlobalBilgiContext(options))
            {
                Category category = new Category();
                category.Name = "Books";
                category.Description = "Sports, etc...";

                context.Categories.Add(category);
                context.SaveChanges();


                var categories = context.Categories.ToList();


            }
        }

    }
}
