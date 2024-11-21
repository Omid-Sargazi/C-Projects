using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Managment.Domin;

namespace HR_Managment.Application.Persistance.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
    }
}