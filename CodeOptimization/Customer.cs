using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public decimal CalculateDiscount() { return IsActive ? 0.1M : 1; }


        public Customer(int Id,string Name,bool IsActive) { this.Id = Id; this.Name = Name; this.IsActive = IsActive; }
    }
}
