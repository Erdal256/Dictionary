using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();

        DbSet<T> _objext;

        public GenericRepository()
        {
            _objext = c.Set<T>();
        }
        public void Delete(T p)
        {
            _objext.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _objext.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _objext.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _objext.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
