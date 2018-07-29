using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Pilot
{
    class PilotViewModel
    {
        #region Variables
        private ObservableCollection<Pilot> pilots;
        #endregion

        #region Getters y setters
        public ObservableCollection<Pilot> Pilots
        {
            get
            {
                if (this.pilots == null)
                {
                    this.pilots = MainWindow.GetPilots();
                }

                return this.pilots;
            }
        }
        #endregion
    }
}
