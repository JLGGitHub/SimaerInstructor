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
using System.Windows.Shapes;
using CaravanInstructor.Classes.Pilot;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.Select
{
    /// <summary>
    /// Interaction logic for NewPilot.xaml
    /// </summary>
    public partial class NewPilot : Window
    {
        private bool _idEdit_boo = false;

        public NewPilot(bool i_isEdit = false)
        {
            _idEdit_boo = i_isEdit;

            InitializeComponent();

            if(_idEdit_boo == true)
            {
                _title_txt.Text = "Edit Pilot";
                _addButton_btn.Content = "Edit";
            }
        }

        /// <summary>
        /// Description: Cierra la ventana
        /// </summary>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Description: Valida el estudiante agregado
        /// </summary>
        private void _addButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if ((_textMilitarCode_tex.Text != "") && (_textFirstName_tex.Text != "") && (_textLastName_tex.Text != ""))
            {
                Pilot pilot = new Pilot();
                pilot.MilitarCode_int = Convert.ToInt64(_textMilitarCode_tex.Text);
                pilot.FirstName_str = _textFirstName_tex.Text;
                pilot.LastName_str = _textLastName_tex.Text;
                Grade grade = _comboGrade_com.SelectedItem as Grade;
                pilot.GradeID_gra = grade;

                if (_idEdit_boo == false)
                {
                    MainWindow.AddPilot(pilot);
                }
                else
                {
                    MainWindow.EditPilots(pilot);
                }

                this.Close();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Complete all fields and press Add",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }

        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textMilitarCode_tex_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textFirstName_tex_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textLastName_tex_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Description: Mueve la interfaz
        /// </summary>
        private void _borderTitle_bor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        /// <summary>
        /// Description: Evento que se ejecuta antes de ingresar la tecla, valida si es un digito
        /// </summary>
        private void _textMilitarCode_tex_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsIntNumeric(e.Text))
            {
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Description: Valida si la tecla es numérica
        /// </summary>
        private bool IsIntNumeric(string _numberInput_str)
        {
            foreach (char c in _numberInput_str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
