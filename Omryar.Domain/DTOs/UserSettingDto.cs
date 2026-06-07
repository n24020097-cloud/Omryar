using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.DTOs
{
    public class UserSettingDto
    {
        public int PersonId { get; set; }
        public string Bio { get; set; }
        public string ProfileImagePath { get; set; }
        public bool IsProfilePublic { get; set; }
        public bool EnableVisitReminder { get; set; }
        public bool EnableMedicineReminder { get; set; }
        public string Theme { get; set; }
        public int FontSize { get; set; }
    }
}
