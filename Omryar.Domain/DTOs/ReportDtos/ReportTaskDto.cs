using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.DTOs.ReportDtos
{
    public class ReportTaskDto
    {
        public int? Id { get; set; }
        public string TaskTitle { get; set; }
        public bool IsCompleted { get; set; }
    }
}
