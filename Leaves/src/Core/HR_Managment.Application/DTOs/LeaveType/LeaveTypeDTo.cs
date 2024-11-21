using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Application.DTOs.Common;


namespace HR_Managment.Application.DTOs.LeaveType
{
    public class LeaveTypeDTo:BaseDTo
    {
        public string Name { get; set; }
        public int DefaultDate { get; set; }
    }
}