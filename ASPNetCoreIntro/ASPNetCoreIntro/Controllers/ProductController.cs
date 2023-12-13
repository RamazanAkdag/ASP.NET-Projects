using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
