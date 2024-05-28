//using System.Linq.Expressions;
//using ADayWithMorte.Shared.Base.Interfaces;

//namespace ADayWithMorte.Shared.Base
//{
//    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
//    {
//        private readonly IUnitOfWork _uow;
//        protected BaseService(IUnitOfWork uow)
//        {

//            _uow = uow;

//        }
//        public Task<IEnumerable<TEntity>> GetAllAsync()
//        {
//        }
//        public Task<TEntity?> GetByAsync(Expression<Func<TEntity, bool>> expression)
//        {
//            throw new NotImplementedException();
//        }
//        public void Insert(TEntity entity)
//        {
//            throw new NotImplementedException();
//        }
//        public void Update(TEntity entity)
//        {
//            throw new NotImplementedException();
//        }
//        public void Delete(int id)
//        {
//            throw new NotImplementedException();
//        }

//    }
//}
