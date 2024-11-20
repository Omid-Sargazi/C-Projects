using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Domin.Common;

namespace HR_Managment.Domin
{
    public class LeaveType:BaseDominEntity
    {
       
        public string Name { get; set; }
        public int DefaultDate { get; set; }
       

    }
}