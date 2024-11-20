using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Domin.Common;

namespace HR_Managment.Domin
{
    public class LeaveAllocation:BaseDominEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }

    }
}