using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Pilot
{
    class Pilot
    {
        #region Variables
        private long _militarCode_int;
        private string _firstName_str;
        private string _lastName_str;
        private Grade _gradeID_gra;
        #endregion

        #region Getters y Setters
        public long MilitarCode_int
        {
            get
            {
                return this._militarCode_int;
            }
            set
            {
                this._militarCode_int = value;
            }
        }

        public string MilitarCode_str
        {
            get
            {
                return this._militarCode_int.ToString();
            }
        }

        public string FirstName_str
        {
            get
            {
                return this._firstName_str;
            }
            set
            {
                this._firstName_str = value;
            }
        }

        public string LastName_str
        {
            get
            {
                return this._lastName_str;
            }
            set
            {
                this._lastName_str = value;
            }
        }

        public Grade GradeID_gra
        {
            get
            {
                return this._gradeID_gra;
            }
            set
            {
                this._gradeID_gra = value;
            }
        }

        public string AbbreviationGrade_str
        {
            get
            {
                return _gradeID_gra.Abbreviation_str;
            }
            set
            {
                this._gradeID_gra.Abbreviation_str = value;
            }
        }
        #endregion

        public Pilot()
        {
            _militarCode_int = 0;
            _firstName_str = "";
            _lastName_str = "";
            _gradeID_gra = new Grade();
        }

        public Pilot(int i_militarCode, string i_firstName, string i_lastName)
        {
            _militarCode_int = i_militarCode;
            _firstName_str = i_firstName;
            _lastName_str = i_lastName;
            _gradeID_gra = new Grade();
        }
    }
}
