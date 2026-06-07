using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain.Entity
{
    public class UserSetting
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Bio { get; set; }
        public string ProfileImagePath { get; set; }
        public bool IsProfilePublic { get; set; }
        public bool EnableVisitReminder { get; set; }
        public bool EnableMedicineReminder { get; set; }
        public string Theme { get; set; } = "Light";
        public int FontSize { get; set; } = 10;
    }
}
