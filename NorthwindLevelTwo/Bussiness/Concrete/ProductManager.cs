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
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {   //dependency injection altyapısı
            this._productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return this._productDal.GetAll();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return this._productDal.GetAll(p => p.CategoryId==categoryId);
        }

        public Product GetById(int productId)
        {
            return _productDal.GetById(p=>p.ProductId==productId);
        }
    }
}
