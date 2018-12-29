using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    public class Report
    {
        bool approval;
        List<string> stepsApproval;

        public bool Approval { get => approval; set => approval = value; }
        public List<string> StepsApproval { get => stepsApproval; set => stepsApproval = value; }
    }
}
