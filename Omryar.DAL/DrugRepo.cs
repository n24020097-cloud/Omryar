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

        public async Task DeleteAsync(int id)
        {
            var result = await _db.Drugs.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);
            result.IsDeleted = true;
            await _db.SaveChangesAsync();
        }

        public async Task<List<Drug>> GetDrugsByPersonIdAsync(int personId)
        {
            var result = await _db.Drugs
                .Where(x => x.IsDeleted == false && x.PersonId== personId)
                .ToListAsync();
            return result;

        }
        public async Task<Drug> GetDrugByIdAsync(int drugId)
        {
            return await _db.Drugs
                .FirstOrDefaultAsync(x => !x.IsDeleted && x.Id == drugId);

        }
        public async Task<bool> UpdateAsync(Drug drug)
        {
            var existingItem = await GetDrugByIdAsync(drug.Id);
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
            return await _db.Drugs.AnyAsync
                (d => d.PersonId == drug.PersonId && d.DrugName == drug.DrugName);
            
        }
    }
}
