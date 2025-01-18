// See https://aka.ms/new-console-template for more information
using Example_1_Solution;
var customerRepo = new CustomerRepository();

var customer1 = new Customer(1, "Berk", true);
var customer2 = new Customer(2, "Polat", false);


customerRepo.Add(customer1);
customerRepo.Add(customer2);

var activeCustomer = customerRepo.GetAllActive();

var discount = DiscountCalculator.CalculateDiscount(customer1);
