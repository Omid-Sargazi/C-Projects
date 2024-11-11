using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IRentable
    {
        Rental Rent(Member member);
    }
}