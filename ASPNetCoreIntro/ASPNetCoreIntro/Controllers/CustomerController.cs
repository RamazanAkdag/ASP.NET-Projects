using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Models;
using ASPNetCoreIntro.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreIntro.Controllers
{
    [Route("deneme")]
    public class CustomerController : Controller
    {
        InLogger _logger;

        public CustomerController(InLogger logger)
        {
            this._logger = logger;
        }

        [Route("notindex")]
        public IActionResult Index()
        {
           
            return View();
        }

        [Route("index")]
        [Route("")]
        public IActionResult index2()
        {
            _logger.Log("selamun aleyküm");
            List<Customer> customers = new List<Customer>
            {
                new Customer{id=1,firstName="Ramazan Fırat",lastName="Akdağ",city="Istanbul"},
                new Customer{id=2,firstName="Öykü",lastName="Atak",city="Aydın"},
                new Customer{id=3,firstName="Rozerin",lastName="Akdağ",city="Istanbul"},
                new Customer{id=4,firstName="Zelal Sultan",lastName="Akdağ",city="Istanbul"},
            };
            List<string> shops = new List<string> { "Ankara", "Istanbul", "Izmir", "Manisa" };
            var model = new CustomerListViewModel { customers = customers, shops = shops };

            return View(model);
        }

        [HttpGet]//default
        [Route("save")]
        public IActionResult saveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                cities=new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="Istanbul",Value="34"},
                    new SelectListItem{Text="Aydin",Value="35"},
                    new SelectListItem{Text="Corum",Value="19"},


                }
            });
        }

        [HttpPost]//default
        [Route("save")]
        public string saveCustomer(Customer customer)
        {
            return "Kaydedildi";

        }
    }
}
