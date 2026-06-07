using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class Report: BaseEntity
    {
        public int PersonId { get; set; }
        public DateTime ReportDate { get; set;}
        public string Notes { get; set; }
        public int WaterCups { get; set; }
        public int Mood { get; set; }
        public virtual ICollection<ReportTask> ReportTasks { get; set; }
    }
}
