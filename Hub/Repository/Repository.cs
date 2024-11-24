using Hub.Data;
using Hub.Models;
using Hub.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hub.Repository
{
    public class Repository : dboperaqtion
    {
        private readonly ApplicationDbContext _db;

        public Repository(ApplicationDbContext db)
        {

            _db = db;

        }
        public async Task createAsync(Company entity)
        {
            await _db.companies.AddAsync(entity);
            await saveAsync();

        }

 






        public async Task saveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task RemoveAsync(Company entity)
        {
            _db.companies.Remove(entity);
            await saveAsync();
        }

        public async Task<List<Company>> GetAllAsync(Expression<Func<Company, bool>>? filter = null)
        {
            IQueryable<Company> query = _db.companies;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task<Company> GetAsync(Expression<Func<Company, bool>>? filter = null)
        {
            IQueryable<Company> query = _db.companies;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Company entity)
        {
            if (entity != null)
            {
                _db.companies.Update(entity);
                await saveAsync();

            }
        }
    }

}
