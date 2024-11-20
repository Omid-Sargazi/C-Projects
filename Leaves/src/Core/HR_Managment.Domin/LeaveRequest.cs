using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Domin.Common;

namespace HR_Managment.Domin
{
    public class LeaveRequest:BaseDominEntity
    {
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }

        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested{ get; set; }

        public string RequestedComments { get; set; }

        public DateTime DateActioned { get; set; }

        public bool? Approve { get; set; }

        public bool Cancelled { get; set; }

    }

}