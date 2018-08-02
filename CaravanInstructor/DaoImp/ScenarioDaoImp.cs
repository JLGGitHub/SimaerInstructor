using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ScenarioDaoImp : IScenarioDao
    {
        public List<scenario> ReadScenarios()
        {
            using (var db = new DbSimaer())
            {
                return db.scenario.Include("time_day").Include("runway_tol").ToList();                 
            }
        }
    }
}
