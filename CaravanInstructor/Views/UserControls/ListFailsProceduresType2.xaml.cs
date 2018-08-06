using CaravanInstructor.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ListFailsProceduresType2.xaml
    /// </summary>
    public partial class ListFailsProceduresType2 : UserControl
    {
        #region Variables
        public List<Procedures> SelectFailsProcedures { get; set; }
        private SystemsCaravan AllFailsProceduresSystem { get; set; }
        #endregion

        public ListFailsProceduresType2()
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

        #region Evento checkboxs
        private void _leftCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            _rightCheckbox_che.IsChecked = false;
            _bothCheckbox_che.IsChecked = false;
        }
        
        private void _rightCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            _leftCheckbox_che.IsChecked = false;
            _bothCheckbox_che.IsChecked = false;
        }

        private void _bothCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            _leftCheckbox_che.IsChecked = false;
            _rightCheckbox_che.IsChecked = false;
        }
        #endregion

        private void _textValue_tex_TextChanged(object sender, TextChangedEventArgs e)
        {
            RadWatermarkTextBox waterMarkTextBox = sender as RadWatermarkTextBox;

            if (waterMarkTextBox.Text == "")
            {
                waterMarkTextBox.Foreground = Brushes.LightGray;
            }
            else
            {
                waterMarkTextBox.Foreground = Brushes.Black;
            }
        }

        /// <summary>
        /// Description: Valida que el texto escrito sea flotante
        /// </summary>
        private void _textValue_tex_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (regex.IsMatch(e.Text) && !(e.Text == "." && ((TextBox)sender).Text.Contains(e.Text)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
