using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using Omryar.Domain.Interfaces;
using Omryar.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class ReportRepo:IReportRepository
    {
        OmryarDbContext _db;
        public ReportRepo(OmryarDbContext db)
        {
            _db =db;
        }
        public async Task AddAsync(Report report)
        {
            _db.DailyReports.Add(report);
            await _db.SaveChangesAsync();
        }
        public async Task<bool> MarkAsDeletedAsync(int id)
        {
            var existingReport = await _db.DailyReports
                .Include(r => r.ReportTasks)
                .FirstOrDefaultAsync(r => r.Id == id && !r.IsDeleted);

            if (existingReport == null)
                return false;

            existingReport.IsDeleted = true;

            foreach (var task in existingReport.ReportTasks)
            {
                task.IsDeleted = true;
            }
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateAsync(Report report)
        {
            var existingReport =await _db.DailyReports
        .Include(r=>r.ReportTasks)
        .FirstOrDefaultAsync(r => r.Id == report.Id);

            if (existingReport == null)
                return false;

            existingReport.PersonId = report.PersonId;
            existingReport.WaterCups = report.WaterCups;
            existingReport.Notes = report.Notes;
            existingReport.Mood = report.Mood;

            var oldTasks = _db.ReportTasks
                .Where(t => t.Id == existingReport.Id)
                .ToList();

            _db.ReportTasks.RemoveRange(oldTasks);

            foreach (var t in report.ReportTasks)
            {
                _db.ReportTasks.Add(new ReportTask
                {
                    TaskTitle = t.TaskTitle,
                    IsCompleted = t.IsCompleted,
                    ReportId = existingReport.Id
                });
            }

            return _db.SaveChanges() > 0;
        }
        public async Task<Report> GetByIdAsync(int id)
        {
            var report = await _db.DailyReports
        .Include(r => r.ReportTasks)
        .FirstOrDefaultAsync(r => r.Id == id && !r.IsDeleted);

            if (report == null)
                return null;

            report.ReportTasks = report.ReportTasks
                .Where(t => !t.IsDeleted)
                .ToList();

            return report;
        }
        public async Task<List<Report>> GetDeletedReportsAsync(int id)
        {
            return await _db.DailyReports
                .Where(r => r.IsDeleted && r.PersonId==id)
                .ToListAsync();
        }
        public async Task RestoreReportAsync(int id)
        {
            var existingItem = await _db.DailyReports
        .Include(r => r.ReportTasks)
        .FirstOrDefaultAsync(r => r.IsDeleted && r.Id == id);

            if (existingItem == null)
                return;

            existingItem.IsDeleted = false;

            foreach (var task in existingItem.ReportTasks)
            {
                task.IsDeleted = false;
            }
            await _db.SaveChangesAsync();
        }
        public async Task<bool> HardDeleteAsync(int id)
        {
            var report = await _db.DailyReports
        .Include(r => r.ReportTasks)
        .FirstOrDefaultAsync(r => r.Id == id);

            if (report == null)
                return false;

            foreach (var task in report.ReportTasks.ToList())
            {
                _db.ReportTasks.Remove(task);
            }

            _db.DailyReports.Remove(report);

            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<List<Report>> SelectReportsAsync(int id)
        {
            return await _db.DailyReports
                .Where(r => !r.IsDeleted &&r.PersonId==id)
                .ToListAsync();
        }
        public async Task<bool> IsDuplicateAsync(Report report)
        {
            var date = report.ReportDate.Date;

            return await _db.DailyReports.AnyAsync(r =>
                r.PersonId == report.PersonId &&
                r.ReportDate == date &&
                !r.IsDeleted &&
                (report.Id == 0 || r.Id != report.Id)
            );
        }
    }
}