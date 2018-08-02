using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class SystemLogic
    {
        private readonly ISystemDao dao;

        public SystemLogic()
        {
            dao = new SystemDaoImp();
        }

        public List<system> ReadSystems()
        {
            return dao.ReadSystems();
        }
    }
}
