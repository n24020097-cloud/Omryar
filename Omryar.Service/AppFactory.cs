using Omryar.DAL;
using Omryar.Domain.Interfaces;
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

        public static IPersonRepository PersonRepository()
        {
            return new PersonRepo(CreateContext());
        }

        public static IPersonService PersonService()
        {
            return new PersonService(
                PersonRepository(),
                UserSettingRepository()
            );
        }

        public static IReportRepository ReportRepository()
        {
            return new ReportRepo(CreateContext());
        }

        public static IReportService ReportService()
        {
            return new ReportService(ReportRepository());
        }

        public static IDrugRepository DrugRepository()
        {
            return new DrugRepo(CreateContext());
        }

        public static IDrugService DrugService()
        {
            return new DrugService(DrugRepository());
        }

        public static IVisitRepository VisitRepository()
        {
            return new VisitReminderRepository(CreateContext());
        }

        public static IVisitService VisitService()
        {
            return new VisitReminderService(VisitRepository());
        }
        public static IUserSettingRepository UserSettingRepository()
        {
            return new UserSettingRepository(CreateContext());
        }

        public static IUserSettingService UserSettingService()
        {
            return new UserSettingService(UserSettingRepository());
        }
    }
}
