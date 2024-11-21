using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HR_Managment.Domin;
using HR_Managment.Application.DTOs.LeaveRequest;
using HR_Managment.Application.DTOs.LeaveType;
using HR_Managment.Application.DTOs.LeaveAllocation;
using HR_Managment.Application.DTOs;



namespace HR_Managment.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest,LeaveRequestDTo>().ReverseMap();
            CreateMap<LeaveRequest,LeaveRequesListDTo>().ReverseMap();
            CreateMap<LeaveType,LeaveTypeDTo>().ReverseMap();
            CreateMap<LeaveAllocation,LeaveAllocationDTo>().ReverseMap();
        }
    }
}