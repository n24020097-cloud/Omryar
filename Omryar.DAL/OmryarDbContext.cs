using Omryar.Domain;
using Omryar.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.DAL
{
    public class OmryarDbContext:DbContext
    {
        public OmryarDbContext() :base("Data Source=.;Initial Catalog=OmryarDb;Integrated Security=True")
        {
            //"Data Source=.;Initial Catalog=OmryarDb;Integrated Security=True"
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Report> DailyReports { get; set; }
        public DbSet<ReportTask> ReportTasks { get; set; }
        public DbSet<VisitReminder> VisitReminders { get; set; }
        public DbSet<UserSetting> UserSettings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Report>()
    .HasKey(r => r.Id);

            modelBuilder.Entity<Report>()
        .HasMany(r => r.ReportTasks)
        .WithRequired(t => t.Report)
        .HasForeignKey(t => t.ReportId)
        .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
