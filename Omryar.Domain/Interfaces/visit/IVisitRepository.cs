using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IVisitRepository
    {
        Task AddAsync(VisitReminder visit);
        Task<bool> UpdateAsync(VisitReminder visit);
        Task<bool> DeleteAsync(int id);
        Task<VisitReminder> GetByIdAsync(int id);
        Task MarkAsNotifiedAsync(int id);
        Task<List<VisitReminder>> GetByPersonIdAsync(int personId);
        Task<List<VisitReminder>> GetUpcoming24HoursAsync(int personId);
    }
}
