using Omryar.Domain;
using Omryar.Domain.DTOs;
using Omryar.Domain.DTOs.PersonDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Helpers
{
    static class StaticData
    {
        public static CurrentUserDto CurrentUser { get; set; }
        public static UserSettingDto CurrentSetting { get; set; }

    }
}
