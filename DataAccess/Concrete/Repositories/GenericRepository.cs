using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        MvcContext c = new MvcContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();

        }
        
        public void Delete(T p)
        {
            using (MvcContext context = new MvcContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            using (MvcContext context = new MvcContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T,bool>>filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            using (MvcContext context = new MvcContext())
            {
                var entity = context.Entry(p);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public int Count()
        {
            int count = (from x in c.Categories select x).Count();
            return count;
        }
    }
}
