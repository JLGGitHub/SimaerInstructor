using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Pilot
{
    class Grade
    {
        #region Variables
        private int _gradeID_int;
        private string _name_str;
        private string _abbreviation_str;
        #endregion

        #region Getters y Setters
        public int GradeID_int
        {
            get
            {
                return this._gradeID_int;
            }
            set
            {
                this._gradeID_int = value;
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

        public string Abbreviation_str
        {
            get
            {
                return this._abbreviation_str;
            }
            set
            {
                this._abbreviation_str = value;
            }
        }
        #endregion

        public Grade()
        {
            _gradeID_int = 0;
            _name_str = "";
            _abbreviation_str = "";
        }

        public Grade(int i_gradeID, string i_name, string i_abbreviation)
        {
            _gradeID_int = i_gradeID;
            _name_str = i_name;
            _abbreviation_str = i_abbreviation;
        }
    }
}
