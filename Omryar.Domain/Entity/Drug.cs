using Omryar.Domain.Entity;
using Omryar.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class Drug: BaseEntity
    {
        public int PersonId { get; set; }
        public string DrugName { get; set; }
        public int Dosage { get; set; }
        public RepeatType ReminderRepeatType { get; set; }
        public int ReminderRepeatValue { get; set; }
        public DateTime ReminderStartTime { get; set; }=DateTime.Now;
        public DateTime? LastReminderTime { get; set; }

        public int ReminderDosage { get; set; }

    }
}
