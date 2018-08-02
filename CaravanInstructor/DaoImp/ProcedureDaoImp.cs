﻿using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class ProcedureDaoImp : IProcedureDao
    {
        public List<procedure> ReadProcedures()
        {
            using (var db = new DbSimaer())
            {
                return db.procedure.ToList();
            }                
        }
    }
}
