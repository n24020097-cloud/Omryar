using Omryar.Domain.Entity;
using Omryar.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class UserSettingRepository : IUserSettingRepository
    {
        private readonly OmryarDbContext _db;

        public UserSettingRepository(OmryarDbContext db)
        {
            _db = db;
        }

        public async Task AddAsync(UserSetting setting)
        {
            _db.UserSettings.Add(setting);
            await _db.SaveChangesAsync();
        }

        public Task<UserSetting> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<UserSetting> GetByPersonIdAsync(int personId)
        {
            return await _db.UserSettings
                .FirstOrDefaultAsync(x => x.PersonId == personId);
        }

        public Task<bool> MarkAsDeletedAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(UserSetting setting)
        {
            var result=await _db.UserSettings.FirstOrDefaultAsync(u=>u.PersonId==setting.PersonId);
            if(result==null) return false;
            result.FontSize= setting.FontSize;
            result.IsProfilePublic=setting.IsProfilePublic;
            result.EnableMedicineReminder=setting.EnableMedicineReminder;
            result.EnableVisitReminder=setting.EnableVisitReminder;
            result.Bio=setting.Bio;
            result.Theme=setting.Theme;
            return await _db.SaveChangesAsync() > 0;
        }
    }
}