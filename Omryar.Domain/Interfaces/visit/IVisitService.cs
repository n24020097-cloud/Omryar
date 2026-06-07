using Omryar.Domain.DTOs;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IVisitService
    {
        Task<OperationResult> AddAsync(VisitReminderDto dto);
        Task<OperationResult> UpdateAsync(VisitReminderDto dto);
        Task<OperationResult> DeleteAsync(int id);
        Task<OperationResult<VisitReminderDto>> GetByIdAsync(int id);
        Task<List<VisitReminderDto>> GetByPersonIdAsync(int personId);
        Task<List<VisitReminderDto>> GetNext24HoursAsync(int personId);
        Task MarkAsNotifiedAsync(int id);
    }
}
