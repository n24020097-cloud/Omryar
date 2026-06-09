using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using Omryar.Domain.Interfaces;
using Omryar.Service.Mappings;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service
{
    public class ReportService:IReportService
    {
        IReportRepository _reportRepo;
        public ReportService(IReportRepository repo)
        {
            _reportRepo = repo;
        }
        public async Task<OperationResult> AddReportAsync(ReportDto report)
        {
            var re=report.ToEntity();
            bool isDuplicate = await _reportRepo.IsDuplicateAsync(re);

            if (isDuplicate)
                return OperationResult.Failed(Messages.ReportMessages.DuplicateReport);

            await _reportRepo.AddAsync(re);
            return OperationResult.Success();
        }
        public async Task<OperationResult> DeleteReportLogicAsync(int id)
        {
            var result = await _reportRepo.MarkAsDeletedAsync(id);
            if (result)
                return OperationResult.Success(Messages.ReportMessages.ReportIsDeleted);
            return OperationResult.Failed(Messages.ReportMessages.ReportNotFound);
        }

        public async Task<List<ReportListDto>> GetDeletedReportAsync(int id)
        {
            var listReport = await _reportRepo.GetDeletedReportsAsync(id);
            return listReport.Select(r=>r.ToReportListDto()).ToList();
        }
        public async Task<OperationResult<ReportDto>> GetReportByIdAsync(int id)
        {
            var result = await _reportRepo.GetByIdAsync(id);
            if (result == null)
                 return OperationResult<ReportDto>.Failed(Messages.ReportMessages.ReportNotFound);
            return OperationResult<ReportDto>.Success("", result.ToReportDto());
        }
        public async Task<OperationResult> HardDeleteAsync(int id)
        {
            var result = await _reportRepo.HardDeleteAsync(id);

            if (!result)
                return OperationResult.Failed(Messages.ReportMessages.ReportNotFound);

            return OperationResult.Success(Messages.ReportMessages.DeleteIsComplete);
        }
        public async Task RestoreReportAsync(int id)
        {
            await _reportRepo.RestoreReportAsync(id);
        }

        public async Task<List<ReportListDto>> SelectReportsAsync(int id)
        {
            var listReport = await _reportRepo.SelectReportsAsync(id);
            return listReport
                .Select(x => x.ToReportListDto())
                .ToList();
        }

        public async Task<OperationResult> UpdateReportAsync(ReportDto report)
        {
            var re = report.ToEntity();
            bool isDuplicate = await _reportRepo.IsDuplicateAsync(re);

            if (isDuplicate)
                return OperationResult.Failed(Messages.ReportMessages.DuplicateReport);

            var result=await _reportRepo.UpdateAsync(re);
            if (result)
                return OperationResult.Success(Messages .ReportMessages.ReportUpdated);
            return OperationResult.Failed(Messages.ReportMessages.ReportNotFound);
        }
    }
}
