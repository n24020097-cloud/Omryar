using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Entity
{
    public class VisitReminder:BaseEntity
    {
        public int PersonId { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string Notes { get; set; }
        public bool IsDone { get; set; } = false;
        public bool IsNotified { get; set; } = false;
    }
}
