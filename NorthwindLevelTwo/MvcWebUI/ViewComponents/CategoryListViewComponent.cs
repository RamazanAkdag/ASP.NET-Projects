using Bussiness.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MvcWebUI.Models;
using System.Reflection.Metadata.Ecma335;

namespace MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent : ViewComponent
    {
        public ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;

        }
        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };

            return View(model);
        }

    
        

    }
}
