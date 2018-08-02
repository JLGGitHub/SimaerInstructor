using CaravanInstructor.Dao;
using CaravanInstructor.Database;
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
                return db.scenario.ToList();
            }
        }
    }
}
