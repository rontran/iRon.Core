using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace iRon.Core.Interfaces
{
    public interface IRepository<Entity,IdType> where IdType:struct where Entity : IEntity<IdType>
    {
        Task<IEnumerable<Entity>> GetAllAsync();

        Task<Entity> FindFirstAsync(Expression<Func<Entity, bool>> where, string cacheSuffix = "");

        Task<int> CountAsync(Expression<Func<Entity, bool>> where);

        Task<IEnumerable<Entity>> FindAsync(Expression<Func<Entity, bool>> where, string cacheSuffix = "");

        Task<bool> ExistsAsync(Expression<Func<Entity, bool>> where);

        Task<Entity> SaveAsync(Entity entity);

        Task<Entity> GetAsync(string id);

        Task<bool> DeleteAsync(Entity entity);

        Task<bool> DeleteAllAsync();


    }
}
