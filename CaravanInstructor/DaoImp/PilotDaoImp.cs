using CaravanInstructor.Dao;
using CaravanInstructor.Database;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;


namespace CaravanInstructor.DaoImp
{
    class PilotDaoImp : IPilotDao
    {
        public bool CreatePilot(pilot InsertPilot)
        {
            using (var db = new DbSimaer())
            {
                db.pilot.Add(InsertPilot);
                db.SaveChanges();

                return true;
            }
        }

        public List<pilot> ReadPilots()
        {
            using (var db = new DbSimaer())
            {
                return db.pilot.ToList();
            }
        }

        public bool UpdatePilot(pilot UpdatePilot)
        {
            using (var db = new DbSimaer())
            {
                db.pilot.AddOrUpdate(UpdatePilot);
                db.SaveChanges();

                return true;
            }
        }

        public bool DeletePilot(pilot DeletePilot)
        {
            using (var db = new DbSimaer())
            {
                db.pilot.Remove(DeletePilot);
                db.SaveChanges();

                return true;
            }
        }              
    }
}
