using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Evaluation
{
    class StructAttribute
    {
        string nameAttribute;
        int idAttibute;
        int typeVariable; 


        public string NameAttribute { get => nameAttribute; set => nameAttribute = value; }
        public int IdAttibute { get => idAttibute; set => idAttibute = value; }
        public int TypeVariable { get => typeVariable; set => typeVariable = value; }
    }
}
