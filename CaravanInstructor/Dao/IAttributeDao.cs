using CaravanInstructor.Model;
using System.Collections.Generic;


namespace CaravanInstructor.Dao
{
    interface IAttributeDao
    {
        List<attribute> ReadAttributes();
        attribute Find(int attribute_id);        
    }
}
