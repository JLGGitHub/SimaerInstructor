using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class ActionLogic
    {
        private readonly IActionDao dao;

        ActionLogic()
        {
            dao = new ActionDaoImp();
        }

        public List<action> ReadActios()
        {
            return dao.ReadActions();
        }
    }
}
