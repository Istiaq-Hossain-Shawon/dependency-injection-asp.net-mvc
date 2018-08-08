using System.Collections.Generic;

namespace DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>(){
                new Customer { CustomerId = 1, City = "Dhaka", CustomerName = "Istiaq" },
                new Customer { CustomerId = 2, City = "Dhaka", CustomerName = "Riyad" },
                new Customer { CustomerId = 3, City = "Chittagong", CustomerName = "Shoikat" },
                new Customer { CustomerId = 4, City = "Barishal", CustomerName = "Ratul" },
            };
        }
    }
}
