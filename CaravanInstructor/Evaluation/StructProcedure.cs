using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CaravanInstructor.Evaluation
{
    public class StructProcedure
    {
        #region Variables

                string nomProcedure; 
                int idProcedure;
                int caseProcedure;  
                int numSteps;

                Dictionary<string, Object> stepsOrden;
                Dictionary<string, Object> stepsDisorden;
                Dictionary<string, Object> stepAlternate;

        #endregion

        #region Encapsulado
        
                public int IdProcedure { get => idProcedure; set => idProcedure = value; }
                public string NomProcedure { get => nomProcedure; set => nomProcedure = value; }
                public int NumSteps { get => numSteps; set => numSteps = value; }
                public int CaseProcedure { get => caseProcedure; set => caseProcedure = value; }

                public Dictionary<string, object> StepsOrden { get => stepsOrden; set => stepsOrden = value; }
                public Dictionary<string, object> StepsDisorden { get => stepsDisorden; set => stepsDisorden = value; }
                public Dictionary<string, object> StepAlternate { get => stepAlternate; set => stepAlternate = value; }


        #endregion


    }
}
