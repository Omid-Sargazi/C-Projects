using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DIWebServer.Interfaces;

namespace DIWebServer.Impementations
{
    public class GreeterService : IGreeterService
    {
        public string Greet(string name)=>$"Hello {name}! Welcome to the web server.";
    }
}