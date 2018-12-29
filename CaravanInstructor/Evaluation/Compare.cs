using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    public class Compare
    {
        
        public bool compare(int typeVarieble, object wantedValue, object currentValue )
        {
            switch(typeVarieble)
            {
                case (int)ManagerEvaluation.TYPE_DATA.BOOLEANO:

                    if ((bool)wantedValue.Equals((bool)currentValue))
                        return true; 

                    break;

                case (int)ManagerEvaluation.TYPE_DATA.INT:

                    if (Convert.ToInt16(wantedValue) == Convert.ToInt16(currentValue))
                        return true;

                    break;

                case (int)ManagerEvaluation.TYPE_DATA.DOUBLE:

                    switch(3)
                    {
                        case (int)ManagerEvaluation.TYPE_COMPARISON.LESS:
                            if (Convert.ToDouble(currentValue) <= Convert.ToDouble(wantedValue))
                                return true;
                            break;

                        case (int)ManagerEvaluation.TYPE_COMPARISON.HIGHER:
             
                        case (int)ManagerEvaluation.TYPE_COMPARISON.EQUAL:
                    }


                    break; 
            }

            return false; 
        }



    }
}
