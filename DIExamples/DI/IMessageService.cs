using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.DI
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }
}