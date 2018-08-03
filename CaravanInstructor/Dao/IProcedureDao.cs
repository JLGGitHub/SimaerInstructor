using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IProcedureDao
    {
        List<procedure> ReadProcedures();
        List<procedure_type> ReadProceduresTypes();
        List<procedure> ReadProceduresBySystemProcType(system i_system, procedure_type i_procedureType);
    }
}
