using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class ReportLogic
    {
        private readonly IReportDao dao;

        public ReportLogic()
        {
            dao = new ReportDaoImp();
        }

        public bool CreateReport(report InsertReport)
        {
            return dao.CreateReport(InsertReport);
        }

        public bool DeleteReport(report DeleteReport)
        {
            return dao.DeleteReport(DeleteReport);
        }

        public List<report> ReadReports()
        {
            return dao.ReadReports();
        }

        public bool UpdateReport(report UpdateReport)
        {
            return dao.UpdateReport(UpdateReport);
        }
    }
}
