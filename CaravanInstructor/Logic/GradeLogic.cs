using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Database;
using System.Collections.Generic;


namespace CaravanInstructor.Logic
{
    class GradeLogic
    {
        private readonly IGradeDao dao;

        public GradeLogic()
        {
            dao = new GradeDaoImp();
        }

        public List<grade> ReadGrades()
        {
            return dao.ReadGrades();
        }
    }
}
