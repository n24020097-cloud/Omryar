using Omryar.Domain.Entity;
using Omryar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class VisitReminderRepository : IVisitRepository
    {
        OmryarDbContext _db;
        public VisitReminderRepository(OmryarDbContext db)
        {
            _db = db;
        }
        public async Task AddAsync(VisitReminder visit)
        {
            _db.VisitReminders.Add(visit);
            await _db.SaveChangesAsync();
        }
        public async Task<bool> UpdateAsync(VisitReminder visit)
        {
            var existingVisit = await _db.VisitReminders
                .FirstOrDefaultAsync(v => v.Id == visit.Id && !v.IsDeleted);

            if (existingVisit == null)
                return false;

            existingVisit.DoctorName = visit.DoctorName;
            existingVisit.Specialty = visit.Specialty;
            existingVisit.VisitDateTime = visit.VisitDateTime;
            existingVisit.Notes = visit.Notes;
            existingVisit.IsDone = visit.IsDone;

            await _db.SaveChangesAsync();

            return true;
        }
        public async Task<VisitReminder> GetByIdAsync(int id)
        {
            return await _db.VisitReminders
                .FirstOrDefaultAsync(v => v.Id == id && !v.IsDeleted);
        }
        public async Task<List<VisitReminder>> GetByPersonIdAsync(int personId)
        {
            return await _db.VisitReminders
                .Where(v => v.PersonId == personId && !v.IsDeleted)
                .OrderBy(v => v.VisitDateTime)
                .ToListAsync();
        }
        public async Task<List<VisitReminder>> GetUpcoming24HoursAsync(int personId)
        {
            var now = DateTime.Now;
            var next24Hours = now.AddHours(24);

            return await _db.VisitReminders
                .Where(v =>
                    v.PersonId == personId &&
                    !v.IsDeleted &&
                    !v.IsDone &&
                    !v.IsNotified &&
                    v.VisitDateTime >= now &&
                    v.VisitDateTime <= next24Hours)
                .OrderBy(v => v.VisitDateTime)
                .ToListAsync();
        }
        public async Task MarkAsNotifiedAsync(int id)
        {
            var visit = await _db.VisitReminders
         .FirstOrDefaultAsync(v => v.Id == id);

            if (visit == null)
                return;

            visit.IsNotified = true;

            await _db.SaveChangesAsync();
        }
        public async Task<bool> MarkAsDeletedAsync(int id)
        {
            var visit =await GetByIdAsync(id);
            if (visit == null)
                return false;
            visit.IsDeleted = true;
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
