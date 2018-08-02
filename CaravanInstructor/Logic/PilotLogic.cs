using CaravanInstructor.Dao;
using CaravanInstructor.DaoImp;
using CaravanInstructor.Database;
using System.Collections.Generic;

namespace CaravanInstructor.Logic
{
    class PilotLogic
    {
        private readonly IPilotDao dao;

        public PilotLogic()
        {
            dao = new PilotDaoImp();
        }

        public bool CreatePilot(pilot InsertPilot)
        {
            return dao.CreatePilot(InsertPilot);
        }

        public List<pilot> ReadPilots()
        {
            return dao.ReadPilots();
        }

        public bool UpdatePilot(pilot UpdatePilot)
        {
            return dao.UpdatePilot(UpdatePilot);
        }

        public bool DeletePilot(pilot DeletePilot)
        {
            return dao.DeletePilot(DeletePilot);
        }

    }
}
