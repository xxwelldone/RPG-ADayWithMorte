﻿namespace ADayWithMorte.Core.Interface.IService
{
    public interface IBaseService<T>
    {
        T GetByModel(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
