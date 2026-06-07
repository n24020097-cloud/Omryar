using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.DTOs.ReportDtos
{
    public class ReportListDto
    {
        public int Id { get; set; }

        public DateTime ReportDate { get; set; }

        public string DisplayTitle=> $"گزارش {ReportDate:yyyy/MM/dd}";
    }
}
