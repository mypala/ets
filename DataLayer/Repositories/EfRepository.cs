using DataLayer.Context;
using DataLayer.Context.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataLayer.Repositories
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ETSContext _context;
        private DbSet<TEntity> _entities;

        public EfRepository(ETSContext context)
        {
            _context = context;
            _entities = Entities;
        }

        /// <summary>
        /// Gets a table
        /// </summary>
        public virtual IQueryable<TEntity> TableWithDeleted => Entities;

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        public virtual IQueryable<TEntity> TableNoTrackingWithDeleted => Entities.AsNoTracking();

        /// <summary>
        /// Entities
        /// </summary>
        protected virtual DbSet<TEntity> Entities => _entities ??= _context.Set<TEntity>();

        public virtual TEntity Find(Expression<Func<TEntity, bool>> criteria)
        {
            return Entities.SingleOrDefault(criteria);
        }

        public virtual List<TEntity> GetList(Expression<Func<TEntity, bool>> criteria)
        {
            return criteria == null
                ? Entities.ToList()
                : Entities.Where(criteria).ToList();
        }

        public virtual TEntity Add(TEntity entity)
        {
            var addedEntity = Entities.Add(entity);
            _context.SaveChanges();
            return addedEntity.Entity;
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> criteria)
        {
            return Entities.SingleOrDefault(criteria);
        }
    }
}