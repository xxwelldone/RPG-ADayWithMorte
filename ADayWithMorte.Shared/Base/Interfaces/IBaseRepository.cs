using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
