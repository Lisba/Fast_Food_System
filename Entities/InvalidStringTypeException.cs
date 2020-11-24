using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvalidStringTypeException : Exception
    {
        public InvalidStringTypeException(string message) : base(message)
        {

        }
        
        public InvalidStringTypeException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
