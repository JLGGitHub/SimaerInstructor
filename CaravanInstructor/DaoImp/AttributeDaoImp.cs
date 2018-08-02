using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.DaoImp
{
    class AttributeDaoImp : IAttributeDao
    {
        public attribute Find(int attribute_id)
        {
            using (var db = new DbSimaer())
            {
                return db.attribute.Find(attribute_id);
            }
        }

        public List<attribute> ReadAttributes()
        {
            using (var db = new DbSimaer())
            {
                return db.attribute.ToList();
            }
        }
    }
}
