using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWebServer02.Interfaces.Logger
{
    public class BusinessService
    {
        private readonly ILogger02 _logger;
        public BusinessService(ILogger02 logger)
        {
            _logger = logger;
        }

        public void PerformTask()
        {
            _logger.Log("Performing a task in the business service.");
        }
    }
}