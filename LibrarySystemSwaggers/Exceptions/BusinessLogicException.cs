using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystemSwaggers.Exceptions
{
    public class BusinessLogicException:Exception
    {
        public BusinessLogicException(string message):base(message){}
        
    }
}