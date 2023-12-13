﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        public IDataResult<List<Category>> GetList();
        IResult Add(Category category);

        IResult Delete(Category category);

        IResult Update(Category category);

    }
}
