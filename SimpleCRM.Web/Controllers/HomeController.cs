using System;
using Microsoft.AspNetCore.Mvc;
using SimpleCRM.Web.Models;

namespace SimpleCRM.Web.Controllers 
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new CustomerModel
            {
                Id=1,
                FirstName="John",
                LastName="Doe",
                PhoneNumber="555-555-4321"
            };
            return new ObjectResult(model);
        }
    }
}
