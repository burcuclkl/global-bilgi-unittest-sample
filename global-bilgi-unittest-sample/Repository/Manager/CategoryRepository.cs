using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Repository.Manager
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly GlobalBilgiContext _dbContext;

        public CategoryRepository(GlobalBilgiContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _dbContext.Categories.FirstOrDefault(q => q.Id == id);
        }
    }
}
