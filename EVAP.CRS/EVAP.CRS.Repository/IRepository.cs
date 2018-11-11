using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EVAP.CRS.Repository
{
    public interface IRepository<T>
                    where T : class
    {
        void Add(T entity);
        void Update(T entity, Expression<Func<T, bool>> predicate);
        void Remove(T entity);
        T FindOne(Expression<Func<T, bool>> predicate);
        List<T> Find(Expression<Func<T, bool>> predicate);
        List<T> FindAll();
    }
}
