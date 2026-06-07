using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.DTOs
{
    public class VisitReminderDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string DoctorName { get; set; }
        public string Specialty { get; set; }
        public DateTime VisitDateTime { get; set; }
        public string DisplayDateTime =>VisitDateTime.ToString("yyyy/MM/dd HH:mm");
        public string Notes { get; set; }
        public bool IsDone { get; set; }
    }
}
