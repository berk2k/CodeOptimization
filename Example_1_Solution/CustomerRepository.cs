using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Solution
{
    public class CustomerRepository : ICustomerRepository
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public void Add(Customer customer) { customers.Add(customer); }

        public IEnumerable<Customer> GetAllActive()
        {
            return customers.Where(c => c.IsActive).ToList();
        }
    }
}
