using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Scenario
{
    class TimeDay
    {
        #region Variables
        private int _timeDayID_int;
        private string _name_str;
        private DateTime _hourDay_dat;
        #endregion
        
        #region Getters y Setters
        public int TimeDayID_int
        {
            get
            {
                return this._timeDayID_int;
            }
            set
            {
                this._timeDayID_int = value;
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

        public DateTime HourDay_dat
        {
            get
            {
                return this._hourDay_dat;
            }
            set
            {
                this._hourDay_dat = value;
            }
        }
        #endregion

        public TimeDay()
        {
            _timeDayID_int = 0;
            _name_str = "";
            _hourDay_dat = new DateTime();
        }

        public TimeDay(int i_timedayID, string i_name, DateTime i_hourDay)
        {
            _timeDayID_int = i_timedayID;
            _name_str = i_name;
            _hourDay_dat = i_hourDay;
        }
    }
}
