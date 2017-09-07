using System;
using System.Linq;

namespace DataAccess.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Func<T, bool> predicate);
        T Find(params object[] key);
        void Update(T obj);
        void Commit();
        void Save(T obj);
        void Delete(Func<T, bool> predicate);
    }
}
