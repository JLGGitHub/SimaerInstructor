using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    interface IDeserialize
    {
        List<StructProcedure> LoadAllProcedure();
        StructProcedure QueryNameProcedure(string nameProcedure);

        List<StructAttribute> LoadAllAttibutes();
        StructAttribute QueryNameAttributes(string nameAttribute);
        List<StructAttribute> listAttributeProcedure(StructProcedure procedure); 


    }
}
