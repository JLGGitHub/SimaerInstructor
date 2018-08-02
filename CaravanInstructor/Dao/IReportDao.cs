using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IReportDao
    {
        bool CreateReport(report InsertReport);
        bool UpdateReport(report UpdateReport);
        bool DeleteReport(report DeleteReport);
        List<report> ReadReports();
    }
}
