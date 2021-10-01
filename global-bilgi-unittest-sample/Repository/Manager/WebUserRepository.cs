using global_bilgi_unittest_sample.ORM;
using global_bilgi_unittest_sample.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace global_bilgi_unittest_sample.Repository.Manager
{
    public class WebUserRepository : IWebUserRepository
    {

        protected readonly GlobalBilgiContext _dbContext;

        public WebUserRepository(GlobalBilgiContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<WebUser> GetAll()
        {
            return _dbContext.WebUsers.ToList();
        }

        public WebUser GetWebUserById(int id)
        {
            return _dbContext.WebUsers.FirstOrDefault(q => q.Id == id);
        }
    }
}
