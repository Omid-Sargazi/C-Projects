using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystemBackend.Exceptions
{
    public class ValidationException:Exception
    {
        public ValidationException(string message) : base(message){}
    }
}