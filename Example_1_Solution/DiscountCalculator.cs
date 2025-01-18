using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Solution
{
    public static class DiscountCalculator
    {
        public static decimal CalculateDiscount(Customer customer) { return customer.IsActive ? 0.1M : 0; } 
    }
}
