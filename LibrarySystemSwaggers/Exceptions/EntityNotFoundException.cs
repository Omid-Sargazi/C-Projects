using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystemSwaggers.Exceptions
{
    public class EntityNotFoundException:Exception
    {
        public EntityNotFoundException(string entityName,object key):base($"{entityName} with ID {key} was not found."){}
    }
}