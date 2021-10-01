using global_bilgi_unittest_sample.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetCategoryById(int id);
    }
}
