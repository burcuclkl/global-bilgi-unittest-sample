using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using global_bilgi_unittest_sample.Repository.Manager;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace globa_bilgi_unit_test_sample.test.DependencyFixture
{
    public class DbFixture
    {

        public ServiceProvider ServiceProvider { get; set; }

        public DbFixture()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<GlobalBilgiContext>(q => q.UseSqlServer("Server=DESKTOP-J7RNMCU; Database=GlobalDb; Trusted_Connection=true"));

            serviceCollection.AddScoped<ICategoryRepository, CategoryRepository>();

            ServiceProvider = serviceCollection.BuildServiceProvider();

        }

    }
}
