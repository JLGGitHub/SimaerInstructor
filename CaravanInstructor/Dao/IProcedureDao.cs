using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IProcedureDao
    {
        List<procedure> ReadProcedures();
    }
}
