using System.Collections.Generic;

namespace MRY.Domain.Abstracts.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void SaveChanges();
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        List<TEntity> GetAll();
    }
}