using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class AttributeLogic
    {
        private readonly IAttributeDao dao;

        public AttributeLogic()
        {
            dao = new AttributeDaoImp();
        }

        public List<attribute> ReadAttributes()
        {
            return dao.ReadAttributes();
        }

    }
}
