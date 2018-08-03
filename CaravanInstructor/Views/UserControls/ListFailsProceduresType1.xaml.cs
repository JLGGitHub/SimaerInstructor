using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using CaravanInstructor.Class;
using Telerik.Windows.Controls;
using CaravanInstructor.Views.FailsProcedures;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ListFailsProceduresType1.xaml
    /// </summary>
    public partial class ListFailsProceduresType1 : UserControl
    {
        #region Variables
        public List<Procedures> SelectFailsProcedures { get; set; }
        private SystemsCaravan AllFailsProceduresSystem { get; set; }
        #endregion

        public ListFailsProceduresType1()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        /// <summary>
        /// Description: Muestra los procedimientos según la selección
        /// </summary>
        public void UpdateData(int i_selectData, SystemsCaravan systemsCaravan)
        {
            AllFailsProceduresSystem = systemsCaravan;
            SelectFailsProcedures = AllFailsProceduresSystem.ProceduresType[i_selectData].Procedures;
            _failProcedures_lis.ItemsSource = SelectFailsProcedures;
            _failProcedures_lis.Items.Refresh();
        }

        /// <summary>
        /// Description: Obtiene el evento para activar o desactivar un procedimiento
        /// </summary>
        private void _checkBoxItem_chb_Click(object sender, RoutedEventArgs e)
        {
            var cb = sender as CheckBox;
            var item = cb.DataContext;
            _failProcedures_lis.SelectedItem = item;

            Procedures procedure = _failProcedures_lis.SelectedItem as Procedures;

            if (procedure != null)
            {
                if (procedure.IsChecked == true)
                {
                    ActivateProcedure activateProcedure = new ActivateProcedure(this);
                    activateProcedure.ParentType_wty = UserControlsType.ListFailsProceduresType1;
                    activateProcedure.ShowDialog();
                }
                else
                {
                    procedure.IsChecked = true;
                    _failProcedures_lis.ItemsSource = SelectFailsProcedures;
                    _failProcedures_lis.Items.Refresh();

                    RadWindow.Confirm(new DialogParameters
                    {
                        Header = "Confirm",
                        Content = "Are you sure you want to end a procedure?",
                        CancelButtonContent = "Cancel",
                        OkButtonContent = "Ok",
                        Closed = new EventHandler<WindowClosedEventArgs>(OnConfirmEndProcedure),
                        Owner = Application.Current.MainWindow
                    });
                }
            }
        }

        /// <summary>
        /// Description: Valida la confirmación de finalizar el procedimiento
        /// </summary>
        public void ConfirmStartProcedure(bool i_confirm)
        {
            Procedures procedure = _failProcedures_lis.SelectedItem as Procedures;

            if (procedure != null)
            {
                if (i_confirm == true)
                {
                    DisableProcedures();
                }

                else
                {
                    procedure.IsChecked = false;
                    _failProcedures_lis.ItemsSource = SelectFailsProcedures;
                    _failProcedures_lis.Items.Refresh();
                }
            }
        }

        /// <summary>
        /// Description: Valida la confirmación de finalizar el procedimiento
        /// </summary>
        private void OnConfirmEndProcedure(object sender, WindowClosedEventArgs e)
        {
            if (e.DialogResult == true)
            {
                Procedures procedure = _failProcedures_lis.SelectedItem as Procedures;

                if (procedure != null)
                {
                    procedure.IsChecked = false;

                    //Método End Procedure
                    EnableProcedures();
                }
            }
        }

        /// <summary>
        /// Description: Habilita todos los checkbox
        /// </summary>
        private void EnableProcedures()
        {
            Procedures procedure = _failProcedures_lis.SelectedItem as Procedures;

            if (procedure != null)
            {
                foreach (var proceduresType in AllFailsProceduresSystem.ProceduresType)
                {
                    foreach (var procedures in proceduresType.Procedures)
                    {
                        procedures.IsEnabled = true;
                    }
                }

                _failProcedures_lis.ItemsSource = SelectFailsProcedures;
                _failProcedures_lis.Items.Refresh();
            }
        }

        /// <summary>
        /// Description: Deshabilita los checkbox de acuerdo a la selección de procedimiento
        /// </summary>
        private void DisableProcedures()
        {
            Procedures procedure = _failProcedures_lis.SelectedItem as Procedures;

            if (procedure != null)
            {
                foreach (var proceduresType in AllFailsProceduresSystem.ProceduresType)
                {
                    foreach (var procedures in proceduresType.Procedures)
                    {
                        if (procedures.Procedure.procedure_id != procedure.Procedure.procedure_id)
                        {
                            procedures.IsEnabled = false;
                        }
                    }
                }

                _failProcedures_lis.ItemsSource = SelectFailsProcedures;
                _failProcedures_lis.Items.Refresh();
            }
        }
    }
}