using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes.Pilot
{
    class GradeViewModel
    {
        #region Variables
        private ObservableCollection<Grade> grades;
        #endregion

        #region Getters y setters
        public ObservableCollection<Grade> Grades
        {
            get
            {
                if (this.grades == null)
                {
                    this.grades = MainWindow.GetGrades();
                }

                return this.grades;
            }
        }
        #endregion
    }
}
