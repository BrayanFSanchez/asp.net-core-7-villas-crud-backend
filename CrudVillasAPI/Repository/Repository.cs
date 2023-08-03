using CrudVillasAPI.Data;
using CrudVillasAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
// using System.Diagnostics;
using System.Linq.Expressions;

namespace CrudVillasAPI.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }

        public async Task  Create(T entity)
        {
            await dbSet.AddAsync(entity);
            await Engrave();
        }

        public async Task Engrave()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter, bool tracked = true)
        {
            IQueryable<T> query = dbSet;
            if(!tracked)
            {
                query = query.AsNoTracking();
            }
            if(filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null)
        {
            IQueryable<T> query = dbSet;
            
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Remove(T entity)
        {
            dbSet.Remove(entity);
            await Engrave();
        }
    }
}
