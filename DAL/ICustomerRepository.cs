using System.Collections.Generic;

namespace DAL
{
  public  interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
