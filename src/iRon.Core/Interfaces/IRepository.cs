using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace iRon.Core.Interfaces
{
    public interface IRepository<E,T,S> where T : struct where S:Enum where E: IEntity<T,S>
    {
        Task<IEnumerable<E>> GetAllAsync();

        Task<E> FindFirstAsync(Expression<Func<E, bool>> where);

        Task<int> CountAsync(Expression<Func<E, bool>> where);

        Task<IEnumerable<E>> FindAsync(Expression<Func<E, bool>> where, string cacheSuffix = "");

        Task<bool> ExistsAsync(Expression<Func<E, bool>> where);

        Task<E> SaveAsync(E entity);

        Task<E> GetAsync(T id);

        Task<bool> DeleteAsync(E entity);
                
        Task<bool> DeleteAll();

        
    }
}
