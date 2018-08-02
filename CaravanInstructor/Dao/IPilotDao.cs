using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Dao
{
    interface IPilotDao
    {
        bool CreatePilot(pilot InsertPilot);
        bool UpdatePilot(pilot UpdatePilot);
        bool DeletePilot(pilot DeletePilot);
        List<pilot> ReadPilots();
    }
}
