﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
            

        List<T> GetAll(Expression<Func<T,bool>> filter = null);

        T GetById(Expression<Func<T, bool>> filter);

        void add(T entity);
        void update(T entity);
        void delete(T entity);

    }
}
