﻿using CaravanInstructor.Model;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IActionDao
    {
        List<action> ReadActions();
        action Find(int action_id);
    }
}
