using Omryar.Domain;
using Omryar.Domain.DTOs.DrugDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class DrugMapper
    {
        public static Drug ToEntity(this DrugDto dto)
        {
            return new Drug()
            {
                Id= dto.Id,
                DrugName = dto.DrugName,
                DrugQty = dto.DrugQty,
                IsActive = dto.IsActive,
                Note = dto.Note,
                RepeatType = dto.RepeatType,
                RepeatValue = dto.RepeatValue,
                LastTakenTime = dto.LastTakenTime,
                PersonId=dto.PersonId
            };
        }

        public static DrugDto ToDto(this Drug entity)
        {
            return new DrugDto()
            {
                Id=entity.Id,
                PersonId=entity.PersonId,
                DrugName = entity.DrugName,
                DrugQty = entity.DrugQty,
                IsActive = entity.IsActive,
                Note = entity.Note,
                RepeatType = entity.RepeatType,
                RepeatValue = entity.RepeatValue,
                LastTakenTime = entity.LastTakenTime
            };
        }
    }
}
