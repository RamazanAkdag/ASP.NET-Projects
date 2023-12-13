using ASPNetCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreIntro.Models
{
    public class SaveCustomerViewModel
    {
        public Customer customer { get; set; }
        public List<SelectListItem> cities { get; set; }
    }
}
