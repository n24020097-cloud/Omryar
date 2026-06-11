using Omryar.DAL;
using Omryar.Domain;
using Omryar.Domain.Interfaces;
using Omryar.Domain.Validators;
using Omryar.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omryar.Service
{
    public static class AppFactory
    {
        private static OmryarDbContext CreateContext()
        {
            return new OmryarDbContext();
        }

        public static IPersonService PersonService()
        {
            var db = CreateContext();
            return new PersonService(
                new PersonRepo(db),
                new UserSettingRepository(db),
                new ValidatorPerson()
            );
        }

        public static IReportService ReportService()
        {
            var db = CreateContext();
            return new ReportService(new ReportRepo(db));
        }

        public static IDrugService DrugService()
        {
            var db = CreateContext();
            return new DrugService(
                new DrugRepo(db),
                new ValidatorDrug()
            );
        }

        public static IVisitService VisitService()
        {
            var db = CreateContext();
            return new VisitReminderService(
                new VisitReminderRepository(db),
                new ValidatorVisitReminder()
            );
        }

        public static IUserSettingService UserSettingService()
        {
            var db = CreateContext();
            return new UserSettingService(
                new UserSettingRepository(db)
            );
        }
    }
}
