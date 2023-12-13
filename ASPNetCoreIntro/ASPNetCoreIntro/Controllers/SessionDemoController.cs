using ASPNetCoreIntro.Entities;
using ASPNetCoreIntro.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro.Controllers
{
    [Route("session")]
    public class SessionDemoController : Controller
    {
        private string _isim = "Engin";

        [Route("index1")]
        public string index1()
        {
            Customer customer = new Customer { id=1, firstName="engin",lastName="demirog"};
            HttpContext.Session.SetString("isim", "Ahmet");
            HttpContext.Session.SetObject("musteri",customer);
            return "Session oluştu...";
        }
        [Route("index2")]
        public string index2()
        {
            Customer customer = HttpContext.Session.GetObject<Customer>("musteri");
           return customer.lastName;
        }
    }
}
