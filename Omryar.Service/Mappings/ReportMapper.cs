using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class ReportMapper
    {
        public static Report ToEntity(this ReportDto dto)
        {
            return new Report
            {
                Id = dto.Id,
                PersonId = dto.PersonId,
                Notes = dto.Notes,
                WaterCups = dto.WaterCups,
                Mood = dto.Mood,
                ReportDate = dto.DateReport,

                ReportTasks = dto.Tasks?.Select(t => new ReportTask
                {
                    TaskTitle = t.TaskTitle,
                    IsCompleted = t.IsCompleted
                }).ToList()
            };
        }

        public static ReportDto ToReportDto(this Report entity)
        {
            var taskList = new List<ReportTaskDto>();
            foreach (var t in entity.ReportTasks)
            {
                taskList.Add(t.ToDto());
            }
            return new ReportDto()
            {
                Id=entity.Id,
                Mood = entity.Mood,
                WaterCups = entity.WaterCups,
                Notes = entity.Notes,
                Tasks = taskList,
                DateReport=entity.ReportDate,
                PersonId = entity.PersonId,
            };
        }

        public static ReportListDto ToReportListDto(this Report entity)
        {
            return new ReportListDto()
            {
                ReportDate = entity.ReportDate,
                Id=entity.Id
            };
        }

    }
}
