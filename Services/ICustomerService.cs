using DAL;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
    }
}
