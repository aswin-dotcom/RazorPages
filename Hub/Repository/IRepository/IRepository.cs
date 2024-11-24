using Hub.Models;
using System.Linq.Expressions;

namespace Hub.Repository.IRepository
{
    public interface dboperaqtion
    {
       Task  createAsync(Company entity);
        Task RemoveAsync(Company entity);

        Task<List<Company>> GetAllAsync(Expression<Func<Company, bool>>?filter=null);


        Task<Company> GetAsync(Expression<Func<Company, bool>>? filter = null);
        Task UpdateAsync(Company entity);  

        Task saveAsync();
  
    }
}
