using Omryar.Domain.DTOs;
using Omryar.Domain.Entity;
using Omryar.Domain.Interfaces;
using Omryar.Service.Mappings;
using Omryar.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Services
{
    public class UserSettingService:IUserSettingService
    {
        private readonly IUserSettingRepository _repo;

        public UserSettingService(IUserSettingRepository repo)
        {
            _repo = repo;
        }

        public async Task<OperationResult<UserSettingDto>> GetAsync(int personId)
        {
            var entity = await _repo.GetByPersonIdAsync(personId);
            if (entity == null)
                return OperationResult<UserSettingDto>.Failed(Messages.SettingMessages.SettingNotFound);
            var dto= entity?.ToDto();
            return OperationResult<UserSettingDto>.Success("", dto);
        }

        public async Task<OperationResult> UpdateAsync(UserSettingDto dto)
        {
            var entity = dto.ToEntity();
            var result= await _repo.UpdateAsync(entity);
            if (result)
                return OperationResult.Success(Messages.SettingMessages.SettingUpdated);
            else
                return OperationResult.Failed(Messages.SettingMessages.Error);
        }
    }
}
