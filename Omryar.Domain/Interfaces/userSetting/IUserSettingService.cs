using Omryar.Domain.DTOs;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Interfaces
{
    public interface IUserSettingService
    {
        Task<OperationResult<UserSettingDto>> GetAsync(int personId);
        Task<OperationResult> UpdateAsync(UserSettingDto dto);
    }
}
