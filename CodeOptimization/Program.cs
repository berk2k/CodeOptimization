using Example_1;
using System.Xml.Linq;

var customerRepo = new CustomerRepository();

var customer1 = new Customer(1,"Berk", true);
var customer2 = new Customer(2, "Polat", false);

customerRepo.Add(customer1);
customerRepo.Add(customer2);   

var allCustomers = customerRepo.GetAll();

var activeCustomer = allCustomers
                    .Where(x => x.IsActive).ToList();

var discount = customer1.CalculateDiscount();

