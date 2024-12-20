using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Common;
using HR_Managment.Application.DTOs.LeaveType;



namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestDTo:BaseDTo
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate{ get; set; }

        public LeaveTypeDTo LeaveTypeDTo { get; set; }
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested{ get; set; }

        public string RequestedComments { get; set; }

        public DateTime DateActioned { get; set; }

        public bool? Approve { get; set; }

        public bool Cancelled { get; set; }
    }
}