using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class PersonMedication: BaseEntity
    {
        public int PersonMedicationId { get; set; }

        public int UseTime { get; set; } = 0;
        public bool? Condition { get; set; }
        public int PillCount { get; set; } = 0;
        public int BasteCount { get; set; } = 0;

        public int PersonId { get; set; }
        public  Person Person { get; set; }
        public int MedicationId { get; set; }
        public Medication Medication { get; set; }=new Medication();

    }
}
