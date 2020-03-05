using System;
using Microsoft.AspNetCore.Mvc;
using SimpleCRM.Web.Models;
using SimpleCRM.Web.Models.Home;

namespace SimpleCRM.Web.Controllers 
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private ICustomerData _customerData;
        private IGreeter _greeter;

        public HomeController(
            ICustomerData customerData,
            IGreeter greeter
        )
        {
            _customerData = customerData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel();
            model.Customers = _customerData.GetAll();
            model.CurrentMessage = _greeter.GetGreeting();
            return View(model);
        }
    }
}
