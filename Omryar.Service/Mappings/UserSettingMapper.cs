using Omryar.Domain.DTOs;
using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class UserSettingMapper
    {
        public static UserSettingDto ToDto(this UserSetting entity)
        {
            return new UserSettingDto
            {
                Bio = entity.Bio,
                EnableMedicineReminder = entity.EnableMedicineReminder,
                EnableVisitReminder = entity.EnableVisitReminder,
                IsProfilePublic = entity.IsProfilePublic,
                 ProfileImagePath = entity.ProfileImagePath,
                 PersonId = entity.PersonId,
                Theme = entity.Theme,
                FontSize = entity.FontSize
            };
        }

        public static UserSetting ToEntity(this UserSettingDto dto)
        {
            return new UserSetting
            {
                PersonId = dto.PersonId,
                IsProfilePublic=dto.IsProfilePublic,
                Bio = dto.Bio,
                ProfileImagePath= dto.ProfileImagePath,
                EnableVisitReminder= dto.EnableVisitReminder,
                EnableMedicineReminder= dto.EnableMedicineReminder,
                Theme = dto.Theme,
                FontSize = dto.FontSize
            };
        }
    }
}
