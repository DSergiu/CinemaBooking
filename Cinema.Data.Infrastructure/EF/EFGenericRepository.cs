namespace Cinema.Data.Infrastructure
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity;

    using Context.Sources;

    public class EFGenericRepository<T> : IGenericRepository<T> where T : class
    {
        public EFGenericRepository(CinemaContext context)
        {
            Set = context.Set<T>();
            Context = context;
        }

        protected CinemaContext Context { get; private set; }
        protected DbSet<T> Set { get; set; }

        #region IRepository<T> Members

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeObjects)
        {
            IQueryable<T> dbQuery = Set;    // Declare a copy of Set because we need to override Set which is not allowed

            // Apply eager loading
            foreach (Expression<Func<T, object>> includeObject in includeObjects)
                dbQuery = dbQuery.Include<T, object>(includeObject);

            IQueryable<T> item = dbQuery.Where(predicate);
            return item;
        }

        public virtual T GetByID(object key)
        {
            return Set.Find(key);
        }

        public virtual void Delete(T entity)
        {
            if (Context.Entry(entity).State == EntityState.Detached)
            {
                Set.Attach(entity);
            }
            Set.Remove(entity);
        }

        public void DeleteById(object key)
        {
            T entity = Set.Find(key);
            Delete(entity);
        }

        public virtual void Insert(T entity)
        {
            Set.Add(entity);
        }

        public virtual void Update(T entity)
        {
            Set.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        #endregion
    }
}
