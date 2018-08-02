using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class ScenarioLogic
    {
        private readonly IScenarioDao dao;

        public ScenarioLogic()
        {
            dao = new ScenarioDaoImp();
        }

        public List<scenario> ReadScenarios()
        {
            return dao.ReadScenarios();
        }
    }
}
