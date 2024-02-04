using TestingEF.DAL.Entities;

namespace TestingEF.DAL.Repositories.Base
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
        Task<IEnumerable<TEntity>> FindAllAsync();
        Task<TEntity> FindAsync(int id);
    }
}
