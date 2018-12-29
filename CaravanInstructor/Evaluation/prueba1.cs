using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    class prueba1
    {
        public void prueba()
        {
            new ManagerEvaluation().processCompleted += Prueba1_processCompleted;
        }

        private void Prueba1_processCompleted(Report report)
        {
            throw new NotImplementedException();
        }
    }
}
