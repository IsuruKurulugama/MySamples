using EVAP.CRS.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EVAP.CRS.Repository
{
    public class Repository<T> : IRepository<T>, IDisposable where T
                                    : class
    {

        private readonly DbSet<T> dbset;
        private readonly DbContext _context;
        private readonly bool _lazyLoadingEnabled = true;


        public Repository(DbContext context, bool lazyLoadingEnabledEnabled)
        : this(context)
        {
            _lazyLoadingEnabled = lazyLoadingEnabledEnabled;
        }

        public Repository(DbContext context)
        {
            _context = context;
            _context.Configuration.LazyLoadingEnabled = _lazyLoadingEnabled;
            dbset = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbset.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity, Expression<Func<T, bool>> predicate)
        {
            var originalValues = FindOne(predicate);
            _context.Entry(originalValues).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbset.Where(predicate).ToList();
        }

        public T FindOne(Expression<Func<T, bool>> predicate)
        {
            return dbset.FirstOrDefault(predicate);
        }

        public List<T> FindAll()
        {
            return dbset.ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
