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

        public async Task Add(Drug drug)
        {
            _db.Drugs.Add(drug);
            await _db.SaveChangesAsync();
        }  

        public async Task Delete(int id)
        {
            var result = await _db.Drugs.Where(x => x.Id == id).SingleAsync();
            result.IsDeleted = true;
           await _db.SaveChangesAsync();
        }

        public async Task<List<Drug>> GetDrugs()
        {
            var result = await _db.Drugs
                .Where(x => x.IsDeleted == false)
                .ToListAsync();
            return result;

        }

        public async Task<List<DrugDto>> Select(int id)
        {
            var result = await _db.Drugs
                .Where(d => d.IsDeleted == false)
                .Where(d => d.PersonId == id)
                .Select(d => new DrugDto
                {
                    Id = d.Id,
                    DrugName = d.DrugName,
                    ReminderDosage = d.ReminderDosage,
                })
                .ToListAsync();
            return result;
        }
        public async Task<List<Drug>> SelectForReminder(int id)
        {
            var result = await _db.Drugs
                .Where(d => d.IsDeleted == false)
                .Where(d => d.PersonId == id)
                .ToListAsync();
            return result;
        }
        public async Task<Drug> Update(int id)
        {
            var result = await _db.Drugs
                .Where(x => x.Id == id)
                .SingleAsync();
            return result;

        }

        public async Task UpdateAndSaveChanges()
        {
           await _db.SaveChangesAsync();
        }
    }
}
