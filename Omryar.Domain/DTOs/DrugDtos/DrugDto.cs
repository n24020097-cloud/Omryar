using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.DTOs.DrugDtos
{
    public class DrugDto
    {
        public int Id { get; set; }
        public string DrugName { get; set; }
        public int ReminderDosage { get; set; }
    }
}
