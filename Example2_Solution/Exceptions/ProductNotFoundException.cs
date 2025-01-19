using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_Solution.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(int productId)
            : base($"Product with ID {productId} not found.")
        {

        }
    }
}
