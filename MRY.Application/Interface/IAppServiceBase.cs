using System.Collections.Generic;

namespace MRY.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        List<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void SaveChanges();
    }
}