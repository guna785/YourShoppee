using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourShoppee.DAL.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int? id);
        IQueryable<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
