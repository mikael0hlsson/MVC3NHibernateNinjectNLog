﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MVC3NHibernateNinjectNLog.Infastructure.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> SaveOrUpdateAll(params T[] entities);
        T SaveOrUpdate(T entity);
        void Delete(T entity);
        void DeleteAll(params T[] entities);
        T Add(T entity);
    }
}