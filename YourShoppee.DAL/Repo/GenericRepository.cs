using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourShoppee.DAL.Context;
using YourShoppee.DAL.Contract;
using YourShoppee.Models.BaseClass;

namespace YourShoppee.DAL.Repo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : CommonModel
    {
        private readonly DbContext _context;
        private DbSet<T> _dbset;
        string errorMessage = string.Empty;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            _dbset.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            _dbset.Remove(entity);
            await _context.SaveChangesAsync();
        }


        public async Task Update(T entity)
        {
            _dbset.Update(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<T> Get(int? id)
        {
            return await _dbset.SingleOrDefaultAsync(s => s.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbset.AsQueryable();
        }
    }
}
