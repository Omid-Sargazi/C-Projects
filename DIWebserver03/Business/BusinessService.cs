using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIWebserver03.Interfaces;

namespace DIWebserver03.Business
{
    
    public class BusinessService
    { private readonly ILoggers _logger;

    public BusinessService(ILoggers logger)
    {
        _logger = logger;
    }

    public void performTask(string message)
    {
        _logger.Log(message);
    }
        
    }
}