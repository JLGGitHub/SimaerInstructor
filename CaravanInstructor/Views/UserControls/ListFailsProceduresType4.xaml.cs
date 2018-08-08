using CaravanInstructor.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CaravanInstructor.Model;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ListFailsProceduresType4.xaml
    /// </summary>
    public partial class ListFailsProceduresType4 : UserControl
    {
        #region Variables
        public List<Procedures> SelectFailsProcedures { get; set; }
        private SystemsCaravan AllFailsProceduresSystem { get; set; }
        #endregion

        public ListFailsProceduresType4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Description: Muestra los procedimientos según la selección
        /// </summary>
        public void UpdateData(int i_selectData, SystemsCaravan systemsCaravan)
        {
            AllFailsProceduresSystem = systemsCaravan;
            SelectFailsProcedures = AllFailsProceduresSystem.ProceduresType[i_selectData].Procedures;
        }

        #region Evento botones
        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            string nameProcedure = (sender as Button).Tag.ToString();
            string valueProcedure = (sender as Button).Content.ToString();
            Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == nameProcedure).First();
            procedure procedure = procedures.Procedure;

            if(procedure != null)
            {
                //Logic procedure

                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Value sent",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }

        private void _clearAllButton_btn_Click(object sender, RoutedEventArgs e)
        {
            foreach (Procedures procedures in SelectFailsProcedures)
            {
                procedure procedure = procedures.Procedure;

                if (procedure != null)
                {
                    //Logic clear procedures
                }
            }

            RadWindow.Alert(new DialogParameters
            {
                Header = "Alert",
                Content = "Values cleared",
                OkButtonContent = "Ok",
                Owner = this
            });
        }
        #endregion
    }
}
