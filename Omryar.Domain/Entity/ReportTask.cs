using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class ReportTask:BaseEntity
    {
        public int ReportId { get; set; }
        public string TaskTitle { get; set; }
        public bool IsCompleted { get; set; }
        public virtual Report Report { get; set; }
    }
}
