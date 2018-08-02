using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Database
{
    public partial class system
    {
        public void InitCategories()
        {
            categories = new List<string>();
            categories.Add("Qualifable");
            categories.Add("NoQualifable");
        }

        public List<string> categories { get; set; }
    }
}
