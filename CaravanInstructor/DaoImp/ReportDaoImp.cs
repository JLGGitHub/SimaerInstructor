using CaravanInstructor.Dao;
using CaravanInstructor.Database;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ReportDaoImp : IReportDao
    {
        public bool CreateReport(report InsertReport)
        {
            using (var db = new DbSimaer())
            {
                db.report.Add(InsertReport);
                db.SaveChanges();

                return true;
            }
        }

        public bool DeleteReport(report DeleteReport)
        {
            using (var db = new DbSimaer())
            {
                db.report.Remove(DeleteReport);
                db.SaveChanges();

                return true;
            }
        }

        public List<report> ReadReports()
        {
            using (var db = new DbSimaer())
            {
                return db.report.ToList();
            }
        }

        public bool UpdateReport(report UpdateReport)
        {
            using (var db = new DbSimaer())
            {
                db.report.AddOrUpdate(UpdateReport);
                db.SaveChanges();

                return true;
            }
        }
    }
}
