using System.Collections.Generic;
using CaravanInstructor.Model;

namespace CaravanInstructor.Class
{
    public class Procedures
    {
        public Procedures(procedure i_procedure)
        {
            Procedure = i_procedure;
            Value = "0";
            IsEnabled = true;
            IsChecked = false;
        }

        public procedure Procedure { get; set; }
        public string Value { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsChecked { get; set; }
    }

    public class ProceduresType
    {
        public ProceduresType(procedure_type i_procedureType)
        {
            ProcedureType = i_procedureType;
            Procedures = new List<Procedures>();
        }

        public procedure_type ProcedureType { get; set; }
        public List<Procedures> Procedures { get; set; }
    }

    public class SystemsCaravan
    {
        public SystemsCaravan(system i_system)
        {
            System = i_system;
            ProceduresType = new List<ProceduresType>();
        }

        public system System { get; set; }
        public List<ProceduresType> ProceduresType { get; set; }
    }
}
