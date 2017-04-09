﻿using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SeatReservationApp.Domain.Repository;

namespace SeatReservationApp.Infrastructure.Repository
{
    public abstract class GenericRepository<T>: IGenericRepository<T> where T : class
    {

        protected DbContext Context;
        protected DbSet<T> _DbSet;

        public GenericRepository(DbContext context)
        {
            Context = context;
            _DbSet = context.Set<T>();
        }

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _DbSet;
            return query;
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _DbSet.Where(predicate);
            return includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }

        public IQueryable<T> FindById(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _DbSet.Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _DbSet.Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _DbSet.Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            if (entity == null) { return; }

            if (Context.Entry(entity).State != EntityState.Detached) { return; }

            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }
    }
}
