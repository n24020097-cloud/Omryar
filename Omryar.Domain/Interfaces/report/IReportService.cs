using Omryar.Domain.DTOs.ReportDtos;
using Omryar.Service;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IReportService
    {
        Task<OperationResult> HardDeleteAsync(int id);
        Task<OperationResult> AddReportAsync(ReportDto report);
        Task<OperationResult> DeleteReportLogicAsync(int id);
        Task<List<ReportListDto>> GetDeletedReportAsync(int id);
        Task<OperationResult<ReportDto>> GetReportByIdAsync(int id);
        Task RestoreReportAsync(int id);
        Task<OperationResult> UpdateReportAsync(ReportDto report);
        Task<List<ReportListDto>> SelectReports(int id);
    }
}
