using System.Collections.Generic;
namespace SimpleCRM.Web.Models.Home
{
    public class HomePageViewModel
    {
        public string CurrentMessage { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}
