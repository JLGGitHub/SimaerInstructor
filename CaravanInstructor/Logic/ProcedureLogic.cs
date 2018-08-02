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

    }
}
