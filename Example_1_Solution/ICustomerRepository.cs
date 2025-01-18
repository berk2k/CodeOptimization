using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Solution
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);

        public IEnumerable<Customer> GetAllActive();
    }
}
