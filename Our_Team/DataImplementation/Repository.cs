﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Our_Team.Interfaces;

namespace Our_Team
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _context;

        private bool disposed = false;

        private DbSet<TEntity> Set { get; }

        public Repository(ApplicationContext context)
        {
            Set = context.Set<TEntity>();
            this._context = context;
        }

        public IQueryable<TEntity> Get<T>()
        {
            return Set;
        }

        public TEntity GetById<T>(Guid? id) where T : class
        {
            return Set.Find(id);
        }

        public void Insert(TEntity entity)
        {
            Set.Add(entity);
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            SaveChanges(true);
        }

        public void Delete<T>(Guid? id) where T : class
        {
            var entity = Set.Find(id);
            if (entity != null)
                Set.Remove(entity);

            SaveChanges(true);
        }

        public void Delete(TEntity item)
        {
            if (_context.Entry(item).State == EntityState.Detached)
            {
                Set.Attach(item);
            }

            Set.Remove(item);
        }

        public void SaveChanges(bool withDisposing = false)
        {
            _context.SaveChanges();

            if (withDisposing)
            {
                Dispose();
            }
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}