using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace iRon.Core.Interfaces
{
    public interface IRepository<Entity, IDType, ObjectStatusEnum> where IDType : struct where ObjectStatusEnum : Enum where Entity : IEntity<IDType, ObjectStatusEnum>
    {
        Task<IEnumerable<Entity>> GetAllAsync();

        Task<Entity> FindFirstAsync(Expression<Func<Entity, bool>> where);

        Task<int> CountAsync(Expression<Func<Entity, bool>> where);

        Task<IEnumerable<Entity>> FindAsync(Expression<Func<Entity, bool>> where, string cacheSuffix = "");

        Task<bool> ExistsAsync(Expression<Func<Entity, bool>> where);

        Task<Entity> SaveAsync(Entity entity);

        Task<Entity> GetAsync(IDType id);

        Task<bool> DeleteAsync(Entity entity);

        Task<bool> DeleteAll();


    }
}
