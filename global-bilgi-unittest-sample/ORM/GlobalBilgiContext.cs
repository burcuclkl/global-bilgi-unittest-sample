using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.ORM
{
    public class GlobalBilgiContext : DbContext
    {

        public GlobalBilgiContext(DbContextOptions<GlobalBilgiContext> options) : base(options)
        {

        }

        public DbSet<WebUser> WebUsers{ get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
