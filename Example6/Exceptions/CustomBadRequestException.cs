using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example6.Exceptions
{
    internal class CustomBadRequestException(string message) : Exception(message)
    {
    }
}
