using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ActionDaoImp : IActionDao
    {
        public action Find(int action_id)
        {
            using (var db = new DbSimaer())
            {
                return db.action.Find(action_id);                                
            }
        }

        public List<action> ReadActions()
        {
            using (var db = new DbSimaer())
            {
                return db.action.ToList();
            }
        }
    }
}
