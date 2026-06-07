using Omryar.Domain.DTOs;
using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class VisitMapper
    {
        public static VisitReminder ToEntity(this VisitReminderDto dto)
        {
            return new VisitReminder
            {
                Id = dto.Id,
                PersonId = dto.PersonId,
                DoctorName = dto.DoctorName,
                Specialty = dto.Specialty,
                VisitDateTime = dto.VisitDateTime,
                Notes = dto.Notes,
                IsDone = dto.IsDone
            };
        }

        public static VisitReminderDto ToDto(this VisitReminder entity)
        {
            return new VisitReminderDto
            {
                Id = entity.Id,
                PersonId = entity.PersonId,
                DoctorName = entity.DoctorName,
                Specialty = entity.Specialty,
                VisitDateTime = entity.VisitDateTime,
                Notes = entity.Notes,
                IsDone = entity.IsDone
            };
        }
    }
}
