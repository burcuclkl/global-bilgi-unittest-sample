using GlobalBilgi.Core.Entities.Base;
using GlobalBilgi.Core.Interfaces.Repository;
using GlobalBilgi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalBilgi.Infrastructure.Repository
{
    public class GenericRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected readonly GlobalTurkcellContext _dbContext;

        public GenericRepository(GlobalTurkcellContext dbContext)
        {
            _dbContext = dbContext;
        }


        public T Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return entity;
        }

        public T Delete(int id)
        {
            var entity = _dbContext.Set<T>().Find(id);
            entity.IsDeleted = true;

            _dbContext.SaveChanges();

            return entity;
        }

        public virtual List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().FirstOrDefault(q => q.Id == id);
        }
    }
}
