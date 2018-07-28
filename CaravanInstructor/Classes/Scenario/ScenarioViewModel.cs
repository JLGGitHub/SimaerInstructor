using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace CaravanInstructor.Classes.Scenario
{
    class ScenarioViewModel
    {
        #region Variables
        private ObservableCollection<Scenario> scenarios;
        private object selectedItem;
        #endregion

        #region Getters y setters
        public ObservableCollection<Scenario> Scenarios
        {
            get
            {
                if (this.scenarios == null)
                {
                    this.scenarios = Scenario.GetScenarios();
                }

                return this.scenarios;
            }
        }
        
        public object SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (value != this.selectedItem)
                {
                    this.selectedItem = value;
                }
            }
        }
        #endregion
    }
}
