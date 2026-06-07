using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IUserSettingRepository
    {
        Task AddAsync(UserSetting setting);
        Task<UserSetting> GetByPersonIdAsync(int personId);
        Task<bool> UpdateAsync(UserSetting setting);
    }
}
