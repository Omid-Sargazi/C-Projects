using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIExamples.DI
{
    public class GuidService : IGuidService
    {
        private readonly Guid _guid = Guid.NewGuid();
        public Guid GetGuid()=> _guid;
    }
}