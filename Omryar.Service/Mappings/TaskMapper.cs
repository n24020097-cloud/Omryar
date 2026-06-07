using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service.Mappings
{
    public static class TaskMapper
    {
        public static ReportTask ToEntity(this ReportTaskDto dto)
        {
            return new ReportTask()
            {
                IsCompleted = dto.IsCompleted,
                TaskTitle = dto.TaskTitle,
            };
        }

        public static ReportTaskDto ToDto(this ReportTask entity)
        {
            return new ReportTaskDto()
            {
                IsCompleted= entity.IsCompleted,
                TaskTitle = entity.TaskTitle,
            };
        }

    }
}
