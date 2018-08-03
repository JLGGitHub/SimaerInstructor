using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ProcedureDaoImp : IProcedureDao
    {
        public List<procedure> ReadProcedures()
        {
            using (var db = new DbSimaer())
            {
                return db.procedure.ToList();
            }                
        }

        public List<procedure_type> ReadProceduresTypes()
        {
            using (var db = new DbSimaer())
            {
                return db.procedure_type.ToList();
            }
        }

        public List<procedure> ReadProceduresBySystemProcType(system i_system, procedure_type i_procedureType)
        {
            using (var db = new DbSimaer())
            {
                return db.procedure.Include("procedure_type").Include("system").Include("action")
                    .Where(oprocedure => oprocedure.procedure_type_id == i_procedureType.procedure_type_id)
                    .Where(oprocedure => oprocedure.system_id == i_system.system_id).OrderBy(oprocedure => oprocedure.procedure_id).ToList();
            }
        }
    }
}
