using Microsoft.Build.Framework;
using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Domain
{
    public class Person: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public virtual ICollection<Drug> Drugs { get; set; }
        public virtual ICollection<VisitReminder> Visits { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
