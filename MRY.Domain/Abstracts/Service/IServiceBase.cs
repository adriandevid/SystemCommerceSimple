using System.Collections.Generic;

namespace MRY.Domain.Abstracts.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        List<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void SaveChanges();
    }
}