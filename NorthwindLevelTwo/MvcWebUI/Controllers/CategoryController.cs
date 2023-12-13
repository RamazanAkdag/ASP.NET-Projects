using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        public ICategoryService _categoryService { get; set; }

        public CategoryController(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
       
    }
}
