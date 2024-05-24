using System.Linq.Expressions;
using ADayWithMorte.Infra.Context;
using ADayWithMorte.Shared.Base.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ADayWithMorte.Infra.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly PostGreeContext _postGreeContext;
        public BaseRepository(PostGreeContext postGreeContext)
        {
            _postGreeContext = postGreeContext;
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var getAll = await _postGreeContext.Set<TEntity>().AsNoTracking().ToListAsync();
            return getAll;
        }

        public async Task<TEntity?> GetByAsync(Expression<Func<TEntity, bool>> expression)
        {
            var obj = await _postGreeContext.Set<TEntity>().FirstOrDefaultAsync(expression);
            return obj;
        }
        public TEntity CreateAsync(TEntity obj)
        {
            _postGreeContext.Set<TEntity>().AddAsync(obj);
            return obj;
        }

        public TEntity Update(TEntity obj)
        {
            _postGreeContext.Set<TEntity>().Update(obj);
            return obj;
        }
        public TEntity Delete(TEntity obj)
        {
            _postGreeContext.Set<TEntity>().Remove(obj);
            return obj;

        }

        public TEntity Create(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
