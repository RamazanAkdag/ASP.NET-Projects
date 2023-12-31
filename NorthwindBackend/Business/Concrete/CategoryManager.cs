﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.categoryAdded + category.CategoryName);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.categoryDeleted + category.CategoryName);
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            var result = _categoryDal.Get(c=>c.CategoryId == categoryId);
            return new SuccessDataResult<Category>(result);
        }

        public IDataResult<List<Category>> GetList()
        {
            var result = _categoryDal.GetList().ToList();
            return new SuccessDataResult<List<Category>>(result);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.categoryUpdated + category.CategoryName);
        }
    }
}
