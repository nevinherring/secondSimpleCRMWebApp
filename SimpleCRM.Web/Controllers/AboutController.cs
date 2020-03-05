using System;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCRM.Web.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        [Route("[action]")]
        public string Address()
        {
            return "USA";
        }
        [Route("")]
        [Route("[action]")]
        public string Phone()
        {
            return "111-555-2828";
        }
    }
}
