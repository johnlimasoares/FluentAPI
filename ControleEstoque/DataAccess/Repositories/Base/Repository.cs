using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories.Base
{
    public abstract class Repository<T> : IDisposable, IRepository<T> where T : class
    {
        public DataContext ctx = new DataContext();

        public virtual void Save(T obj)
        {
            ctx.Set<T>().Add(obj);
        }

        public virtual void Update(T obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Commit()
        {
            ctx.SaveChanges();
        }

        public virtual void Delete(Func<T, bool> predicate)
        {
            ctx.Set<T>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<T>().Remove(del));
        }

        public virtual T Find(params object[] key)
        {
            return ctx.Set<T>().Find(key);
        }

        public virtual IQueryable<T> Get(Func<T, bool> predicate)
        {
            if(predicate == null)
                return GetAll();

            return GetAll().Where(predicate).AsQueryable();
        }

        public virtual IQueryable<T> GetAll()
        {
            return ctx.Set<T>();
        }

        public void Dispose()
        {
            ctx.Dispose();
        }
    }
}
