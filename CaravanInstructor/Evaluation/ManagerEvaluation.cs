using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CaravanInstructor.Evaluation
{
    public class ManagerEvaluation
    {
        private StructProcedure qualifyProcedure;
        private bool approval;
        private int caseEvaluation;
        private bool runProcedure; 
        private Compare compareAtt;
        StructAttribute attribute;
        List<StructAttribute> attRegistry;
        private Report report; 
        DispatcherTimer timerProcedure;

        public delegate void ProcessCompleted(Report report); 
        public event ProcessCompleted processCompleted; 

        public StructProcedure QualifyProcedure { get => qualifyProcedure; set => qualifyProcedure = value; }
        public bool Approval { get => approval; set => approval = value; }
        public Compare CompareAtt { get => compareAtt; set => compareAtt = value; }
        public int CaseEvaluation { get => caseEvaluation; set => caseEvaluation = value; }
        internal StructAttribute Attribute { get => attribute; set => attribute = value; }
        internal List<StructAttribute> AttRegistry { get => attRegistry; set => attRegistry = value; }
        public bool RunProcedure { get => runProcedure; set => runProcedure = value; }
        public Report Report { get => report; set => report = value; }

        public enum TYPE_DATA
        {
            BOOLEANO = 1, 
            INT = 2, 
            DOUBLE = 4
        }

        public enum TYPE_CASE
        {
            ORDER = 1, 
            DISORDER = 2, 
            ALTERNATE = 3
        }

        public enum TYPE_COMPARISON
        {
            EQUAL = 1, 
            HIGHER = 2, 
            LESS = 3
        }

        public ManagerEvaluation()
        {
            QualifyProcedure = new StructProcedure();
            Attribute = new StructAttribute();
            CompareAtt = new Compare();
            CaseEvaluation = 0;
            Approval = false;
            runProcedure = true;
            timerProcedure = new DispatcherTimer();
        }



        public bool startProcedure(string nameProcedure)
        {
             // Procedimiento a calificar.
            QualifyProcedure = new Deserialize().QueryNameProcedure(nameProcedure);
            // Lista de atributos a registrar en simbox 
            AttRegistry = new Deserialize().listAttributeProcedure(QualifyProcedure);

            timerProcedure.Interval = new TimeSpan(0, 0, 15);
            timerProcedure.Tick += TimerProcedure_Tick;
            timerProcedure.Start(); 

            switch (QualifyProcedure.CaseProcedure)
            {
                case (int)TYPE_CASE.ORDER:

                    report = new Report(); 
                    Approval = evaluationCaseOne(QualifyProcedure.StepsOrden.Keys, QualifyProcedure.StepsOrden.Values);

                    if (processCompleted != null)
                    {
                        processCompleted(report);  // envio del reporte, a los suscriptores. 
                    }

                    break;

                case (int)TYPE_CASE.DISORDER:

                    report = new Report();
                    Approval = evaluationCaseTwo(QualifyProcedure.StepsDisorden.Keys.ToList(), QualifyProcedure.StepsDisorden.Values.ToList());

                    if (processCompleted != null)
                    {
                        processCompleted(report);  // envio del reporte, a los suscriptores.
                    }

                    break;

                case (int)TYPE_CASE.ALTERNATE:

                    report = new Report();
                    Approval = evaluationCaseOne(QualifyProcedure.StepsOrden.Keys, QualifyProcedure.StepsOrden.Values);
                    evaluationCaseThree(QualifyProcedure.StepsDisorden.Keys.ToList(), QualifyProcedure.StepsDisorden.Values.ToList());

                    if (processCompleted != null)
                    {
                        processCompleted(report);  // envio del reporte, a los suscriptores.
                    }

                    break; 
            }

            return true; 
        }

      

        public bool stopProcedure()
        {
            // Aqui se llama al reporte final. 

            return true; 
        }

        // Caso de evaluacion 1: Pasos ordenados.  
        public bool evaluationCaseOne(Dictionary<string,object>.KeyCollection listAttOrden, Dictionary<string, object>.ValueCollection listValueOrden)
        {
            List<object> x = new List<object>(); // Solo para pruebas. 
            x.Add(100);
            x.Add(2);
            x.Add(true);

            int index = 0;
            bool result = false;
 
            foreach (string nameAttribute in listAttOrden)
            { 
                Attribute = new Deserialize().QueryNameAttributes(nameAttribute);
                // ValorActual = Service.Instance.GetAttribute(name);
                do
                {
                    result = compareAtt.compare(Attribute.TypeVariable, listValueOrden.ElementAt(index), x.ElementAt(index));
                    //if (true)
                    //    Report.StepsApproval.Add(nameAttribute); 
                    
                }while (!result && runProcedure); 

                index++; 
            }
            return true; 
        }

        //Caso de evaluacion 2: Pasos no ordenados
        public bool evaluationCaseTwo(List<string> listAttDisorden, List<object> listValueDisorden)
        {
            List<object> x = new List<object>();  // Solo para pruebas.
            x.Add(2);
            x.Add(3);
            x.Add(11);
            x.Add(175);

            int index = 0;
            bool result = false;
            bool run = true;
            
            List<int> indexDeleteList; 

            do
            {
                indexDeleteList = new List<int>();
                foreach (string nameAttribute in listAttDisorden)
                {
                    Attribute = new Deserialize().QueryNameAttributes(nameAttribute);
                    result = compareAtt.compare(Attribute.TypeVariable, listValueDisorden.ElementAt(index), x.ElementAt(index));

                    if (result)
                    {
                        indexDeleteList.Add(index);
                    }
                                      
                    index++;
                }
                indexDeleteList.Reverse(); 
                foreach (int item in indexDeleteList)
                {
                    listAttDisorden.RemoveAt(item); 
                    listValueDisorden.RemoveAt(item);
                }
                run = (listAttDisorden.Count == 0) ? false : true;  

            } while (run && runProcedure); 

            return true; 
        }


        //Caso de evaluacion 3: Pasos Ordenados, no ordenados o ruta alterna. 
        public bool evaluationCaseThree(List<string> listAttDisorden, List<object> listValueDisorden)
        {
            // Logica aqui... 

            return true; 
        }

        // Evento: Ejercicio finalizado por tiempo.  

        private void TimerProcedure_Tick(object sender, EventArgs e)
        {
            timerProcedure.IsEnabled = false;
            runProcedure = false;

        }
    }
}
