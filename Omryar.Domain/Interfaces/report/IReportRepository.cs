using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IReportRepository : IRepository<Report>
    {
        Task<bool> HardDeleteAsync(int id);
        Task<bool> UpdateAsync(Report report);
        Task RestoreReportAsync(int id);
        Task<List<Report>> GetDeletedReportsAsync(int id);
        Task<List<Report>> SelectReportsAsync(int id);
        Task<bool> IsDuplicateAsync(Report report);
    }
}
