using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    public interface IRepository<T>
    {
        void Add(T item);

        IEnumerable<T> GetAll();
    }

    public class CustomerRepository : IRepository<Customer>, ICustomerActions
    {
        public List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            //duplicate check
            if(customers.Any(c => c.Id == customer.Id))
            {
                throw new Exception("Duplicate Id");
            }

            customers.Add(customer);
        }

        public void ArchiveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers.ToList();
        }
    }
}
