//using ADayWithMorte.Shared.Base.Interfaces;

//namespace ADayWithMorte.Shared.Base
//{
//    public abstract class BaseService<T> : IBaseService<T> where T : class
//    {
//        private readonly IBaseRepository<T> _repository;

//        public BaseService(IBaseRepository<T> repository)
//        {
//            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
//        }

//        public T GetByModel(int id)
//        {
//            return _repository.GetByID(id);
//        }


//        public void Insert(T entity)
//        {
//            _repository.Insert(entity);
//        }


//        public void Update(T entity)
//        {
//            _repository.Update(entity);
//        }


//        public void Delete(int id)
//        {
//            _repository.Delete(id);
//        }

//    }
//}
