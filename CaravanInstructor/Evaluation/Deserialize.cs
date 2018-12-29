using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    class Deserialize: IDeserialize
    {
        public List<StructAttribute> listAttributeProcedure(StructProcedure _procedure)
        {
            List<StructAttribute> listAttribute = new List<StructAttribute>();

            List<StructProcedure> procedures = JsonConvert.DeserializeObject<List<StructProcedure>>((File.ReadAllText(path: "Evaluation/Procedures.json")));
            StructProcedure procedure = procedures.Find(x => x.NomProcedure.Contains(_procedure.NomProcedure));

            List<string> nameAttListProcedure = new List<string>(); 

            switch (_procedure.CaseProcedure)
            {
                case (int)ManagerEvaluation.TYPE_CASE.ORDER:
                  nameAttListProcedure.AddRange(procedure.StepsOrden.Keys.ToList());

                    break;

                case (int)ManagerEvaluation.TYPE_CASE.DISORDER:
                   nameAttListProcedure.AddRange(procedure.StepsDisorden.Keys.ToList());
                    break;

                case (int)ManagerEvaluation.TYPE_CASE.ALTERNATE:
                    nameAttListProcedure.AddRange(procedure.StepsOrden.Keys.ToList());
                    nameAttListProcedure.AddRange(procedure.StepAlternate.Keys.ToList());
                    break;
            }

            listAttribute = JsonConvert.DeserializeObject<List<StructAttribute>>((File.ReadAllText(path: "Evaluation/Attributes.json")));
           
            listAttribute = (from att in listAttribute
                             from str in nameAttListProcedure
                             where att.NameAttribute.Equals(str)
                             select att).ToList(); 

            return listAttribute; 
        }

        public List<StructAttribute> LoadAllAttibutes()
        {
            List<StructAttribute> attributes = new List<StructAttribute>(); 
            attributes = JsonConvert.DeserializeObject<List<StructAttribute>>((File.ReadAllText(path: "Evaluation/Attributes.json")));
            return attributes; 
        }

        public List<StructProcedure> LoadAllProcedure()
        {
            List<StructProcedure> procedure = new List<StructProcedure>();
            procedure = JsonConvert.DeserializeObject<List<StructProcedure>>((File.ReadAllText(path: "Evaluation/Procedures.json")));

            return procedure;
        }

        public StructAttribute QueryNameAttributes(string nameAttribute)
        {
            List<StructAttribute> attributes = new List<StructAttribute>();
            attributes = JsonConvert.DeserializeObject<List<StructAttribute>>((File.ReadAllText(path: "Evaluation/Attributes.json")));
            StructAttribute attribute = attributes.Find(x => x.NameAttribute.Contains(nameAttribute));
            return attribute;
        }

        public StructProcedure QueryNameProcedure(string nameProcedure)
        {
            List<StructProcedure> procedures = new List<StructProcedure>();
            procedures = JsonConvert.DeserializeObject<List<StructProcedure>>((File.ReadAllText(path: "Evaluation/Procedures.json")));
            StructProcedure procedure = procedures.Find(x => x.NomProcedure.Contains(nameProcedure));

            return procedure;
        }




    }
}
