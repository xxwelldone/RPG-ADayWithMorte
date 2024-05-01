using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ADayWithMorte.Shared.Base.Interfaces;

namespace ADayWithMorte.Shared.Base
{
    public class BaseRespository<TEntity> : IBaseRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> GetByAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
        public TEntity Create(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
        public TEntity Delete(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
