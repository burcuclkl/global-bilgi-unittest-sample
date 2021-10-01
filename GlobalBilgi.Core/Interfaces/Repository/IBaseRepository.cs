using GlobalBilgi.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlobalBilgi.Core.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : Entity
    {

        List<T> GetAll();
        Task<List<T>> GetAllAsync();

        T Add(T entity);

        T Delete(int id);

        T GetById(int id);
    }
}
