using Omryar.Domain;
using Omryar.Domain.DTOs.PersonDtos;
using Omryar.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class PersonMapper
    {
        public static Person ToEntity(this AddPersonDto dto)
        {
            return new Person()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                NationalCode = dto.NationalCode,
                Mobile = dto.Mobile,
                PasswordHash = "",
                UserName = dto.UserName
            };
        }

        public static CurrentUserDto ToPersnInfoDto(this AddPersonDto addDto)
        {
            return new CurrentUserDto()
            {
                FirstName = addDto.FirstName,
                LastName = addDto.LastName,
                Id = addDto.Id
            };
        }
        public static CurrentUserDto ToPersnInfoDto(this Person entity)
        {
            return new CurrentUserDto()
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Id = entity.Id
            };
        }
    }
}
