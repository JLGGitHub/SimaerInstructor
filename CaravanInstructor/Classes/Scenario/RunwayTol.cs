using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Scenario
{
    class RunwayTol
    {
        #region Variables
        private int _runWayTolID_int;
        private string _name_str;
        #endregion

        #region Getters y Setters
        public int RunWayTolID_int
        {
            get
            {
                return this._runWayTolID_int;
            }
            set
            {
                this._runWayTolID_int = value;
            }
        }

        public string Name_str
        {
            get
            {
                return this._name_str;
            }
            set
            {
                this._name_str = value;
            }
        }
        #endregion

        public RunwayTol()
        {
            _runWayTolID_int = 0;
            _name_str = "";
        }

        public RunwayTol(int i_runWayTolID, string i_name)
        {
            _runWayTolID_int = i_runWayTolID;
            _name_str = i_name;
        }
    }
}
