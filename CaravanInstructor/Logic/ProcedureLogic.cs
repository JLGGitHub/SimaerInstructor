using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class ProcedureLogic
    {
        private readonly IProcedureDao dao;

        public ProcedureLogic()
        {
            dao = new ProcedureDaoImp();
        }

        public List<procedure> ReadProcedures()
        {
            return dao.ReadProcedures();
        }

        public List<procedure_type> ReadProceduresTypes()
        {
            return dao.ReadProceduresTypes();
        }

        public List<procedure> ReadProceduresBySystemProcType(system i_system, procedure_type i_procedureType)
        {
            return dao.ReadProceduresBySystemProcType(i_system, i_procedureType);
        }
    }
}
