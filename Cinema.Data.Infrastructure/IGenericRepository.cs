namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IGenericRepository<T> where T : class
    {
        T GetByID(object key);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeObjects);
        void Delete(T entity);
        void DeleteById(object key);
        void Insert(T entity);
        void Update(T entity);
    }
}
