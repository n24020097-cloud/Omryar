using Omryar.Domain;
using Omryar.Domain.Interfaces;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class PersonRepo : IPersonRepository
    {
        OmryarDbContext _db;
        public PersonRepo(OmryarDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(Person entity)
        {
            _db.People.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task<bool> MarkAsDeletedAsync(int id)
        {
            var existingItem = await _db.People.
                FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);
            if (existingItem == null)
                return false;
            existingItem.IsDeleted= true;
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<Person> GetByIdAsync(int id)
        {
            return await _db.People.FirstOrDefaultAsync(p=>p.Id == id && !p.IsDeleted);
        }

        public async Task<List<Person>> SelectPeopleAsync()
        {
            return await _db.People.Where(p=>!p.IsDeleted).ToListAsync();
        }

        public async Task<Person> GetByUserNameAsync(string userName)
        {
            return await _db.People.FirstOrDefaultAsync(p=>p.UserName==userName && !p.IsDeleted);
        }

        public async Task<bool> IsDuplicateNationalCodeAsync(string nationalCode)
        {
            return await _db.People.AnyAsync(p=>p.NationalCode==nationalCode
            && !p.IsDeleted);
        }

        public async Task<bool> IsDuplicateUserNameAsync(string username)
        {
            return await _db.People.AnyAsync(p => p.UserName == username
            && !p.IsDeleted);
        }

        public async Task<bool> UpdateAsync(Person person)
        {
            var result = await GetByIdAsync(person.Id);

            if (result == null)
                return false;

            result.FirstName = person.FirstName;
            result.LastName = person.LastName;
            result.Mobile = person.Mobile;
            result.NationalCode = person.NationalCode;
            result.UserName = person.UserName;

            await _db.SaveChangesAsync();
            return true;
        }
    }
}
