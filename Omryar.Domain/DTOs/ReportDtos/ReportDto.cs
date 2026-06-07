using Omryar.Domain;
using Omryar.Domain.DTOs.ReportDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service
{
    public class ReportDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Notes { get; set; }
        public int WaterCups { get; set; }
        public DateTime DateReport { get; set; }
        public int Mood { get; set; }
        public List<ReportTaskDto> Tasks { get; set; }
    }
}
