using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class GradeDaoImp : IGradeDao
    {
        public List<grade> ReadGrades()
        {
            using (var db = new DbSimaer())
            {
                return db.grade.ToList();
            }
        }
    }
}
