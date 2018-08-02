﻿using CaravanInstructor.Dao;
using CaravanInstructor.Model;
using System.Collections.Generic;
using System.Linq;

namespace CaravanInstructor.DaoImp
{
    class SystemDaoImp : ISystemDao
    {
        public List<system> ReadSystems()
        {
            using (var db = new DbSimaer())
            {
                return db.system.ToList();
            }
        }
    }
}
