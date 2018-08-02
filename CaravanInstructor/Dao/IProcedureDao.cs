using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IProcedureDao
    {
        List<procedure> ReadProcedures();
    }
}
