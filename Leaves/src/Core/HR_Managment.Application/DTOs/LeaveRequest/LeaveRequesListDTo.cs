using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Common;
using HR_Managment.Application.DTOs.LeaveType;

namespace HR_Managment.Application.DTOs.LeaveRequest
{
    public class LeaveRequesListDTo:BaseDTo
    {
        public LeaveTypeDTo LeaveTypeDTo { get; set; }
         public DateTime DateRequested{ get; set; }
          public bool? Approve { get; set; }

    }
}