using System;
using System.Collections.Generic;
namespace SimpleCRM
{
    public interface ICustomerData
    {
        IEnumerable<Customer> GetAll();
    }
}
