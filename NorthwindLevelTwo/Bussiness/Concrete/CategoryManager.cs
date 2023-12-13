using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
          this._categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return this._categoryDal.GetAll();           
        }
    }
}
