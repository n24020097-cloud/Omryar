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
        public RepeatType RepeatType { get; set; }
        public int RepeatValue { get; set; }
        public bool IsActive { get; set; }
        public string Note { get; set; }
        public DateTime LastTakenTime { get; set; }
        public int DrugQty { get; set; }
        public DateTime NextTokenTime { get; set; }
    }
}
