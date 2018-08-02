using CaravanInstructor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Dao
{
    interface IScenarioDao
    {
        List<scenario> ReadScenarios();
    }
}
