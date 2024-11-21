using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Common;
using HR_Managment.Application.DTOs.LeaveType;


namespace HR_Managment.Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDTo:BaseDTo
    {
        public int NumberOfDays { get; set; }
        public LeaveTypeDTo LeaveTypeDTo { get; set; }
        public int LeaveTypeId { get; set; }
        public int Priod { get; set; }
    }
}