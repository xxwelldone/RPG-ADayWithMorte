
using System.Linq.Expressions;


namespace ADayWithMorte.Shared.Base.Interfaces
{
    public interface IBaseRepository<TEntity> 
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByAsync(Expression<Func<TEntity, bool>> expression);

        TEntity CreateAsync(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Delete(TEntity obj);

    }
}
