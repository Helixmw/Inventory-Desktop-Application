using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplication.Exceptions
{
    public class DatabaseOperationException : Exception
    {
        public DatabaseOperationException(string message):base(message)
        {
            
        }

        public DatabaseOperationException()
        {
            
        }
    }
}
