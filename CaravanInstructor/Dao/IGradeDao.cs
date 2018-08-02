using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanInstructor.Model;

namespace CaravanInstructor.Dao
{
    interface IGradeDao
    {
        List<grade> ReadGrades();
    }
}
