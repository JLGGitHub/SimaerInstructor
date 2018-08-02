using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanInstructor.Database;


namespace CaravanInstructor.Dao
{
    interface ISystemDao
    {
        List<system> ReadSystems();
    }
}
