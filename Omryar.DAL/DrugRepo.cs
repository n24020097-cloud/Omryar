using Omryar.Domain;
using Omryar.Domain.DTOs.DrugDtos;
using Omryar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class DrugRepo : IDrugRepository
    {
        OmryarDbContext _db;
        public DrugRepo(OmryarDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Drug drug)
        {
            _db.Drugs.Add(drug);
            await _db.SaveChangesAsync();
        }  
        public async Task<List<Drug>> GetDrugsByPersonIdAsync(int personId)
        {
            var result = await _db.Drugs
                .Where(x => x.IsDeleted == false && x.PersonId== personId)
                .ToListAsync();
            return result;

        }
        public async Task<bool> UpdateAsync(Drug drug)
        {
            var existingItem = await GetByIdAsync(drug.Id);
            if (existingItem == null) return false;
            existingItem.Note = drug.Note;
            existingItem.DrugQty = drug.DrugQty;
            existingItem.DrugName= drug.DrugName;
            existingItem.IsActive = drug.IsActive;
            existingItem.LastTakenTime = drug.LastTakenTime;
            existingItem.RepeatValue = drug.RepeatValue;
            existingItem.RepeatType= drug.RepeatType;
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<bool> IsDuplicateAsync(Drug drug)
        {
            return await _db.Drugs.AnyAsync(
                d => d.PersonId == drug.PersonId
                && d.DrugName == drug.DrugName
                && d.Id != drug.Id
                && !d.IsDeleted);

        }
        public async Task<Drug> GetByIdAsync(int id)
        {
            return await _db.Drugs
                .FirstOrDefaultAsync(x => !x.IsDeleted && x.Id == id);
        }
        public async Task<List<Drug>> GetTodayDrugsAsync(int personId)
        {
            var start = DateTime.Today;
            var end = start.AddDays(1);

            return await _db.Drugs
                .Where(d => d.PersonId == personId
                         && !d.IsDeleted
                         && d.IsActive
                         && d.NextTokenTime >= start
                         && d.NextTokenTime < end)
                .ToListAsync();
        }
        public async Task UpdateAfterTakenAsync(int drugId,DateTime takenTime, DateTime nextTokenTime)
        {
            var drug = await _db.Drugs
                .FirstOrDefaultAsync(d => d.Id == drugId && !d.IsDeleted);
            if (drug == null) return;

            drug.LastTakenTime = takenTime;
            drug.NextTokenTime = nextTokenTime;
            drug.DrugQty--;
            await _db.SaveChangesAsync();
        }
        public async Task<bool> MarkAsDeletedAsync(int id)
        {
            var result = await _db.Drugs.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            if (result == null) return false;
            result.IsDeleted = true;
            await _db.SaveChangesAsync();
            return true;
        }
        public async Task<Drug> GetNextDrugAsync(int personId)
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            return await _db.Drugs
                .Where(d => d.PersonId == personId
                         && !d.IsDeleted
                         && d.IsActive
                         && d.NextTokenTime >= today
                         && d.NextTokenTime < tomorrow)
                .OrderBy(d => d.NextTokenTime)
                .FirstOrDefaultAsync();
        }
    }
}
