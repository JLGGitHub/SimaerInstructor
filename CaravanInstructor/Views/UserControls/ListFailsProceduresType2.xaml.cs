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
using CaravanInstructor.Model;

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
        /// <summary>
        /// Description: Deshabilita las demás opciones
        /// </summary>
        private void _leftCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            if(_leftCheckbox_che.IsChecked == true)
            {
                _rightCheckbox_che.IsChecked = false;
                _bothCheckbox_che.IsChecked = false;
            }
        }

        /// <summary>
        /// Description: Deshabilita las demás opciones
        /// </summary>
        private void _rightCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            if (_rightCheckbox_che.IsChecked == true)
            {
                _leftCheckbox_che.IsChecked = false;
                _bothCheckbox_che.IsChecked = false;
            }
        }

        /// <summary>
        /// Description: Deshabilita las demás opciones
        /// </summary>
        private void _bothCheckbox_che_Click(object sender, RoutedEventArgs e)
        {
            if (_rightCheckbox_che.IsChecked == true)
            {
                _bothCheckbox_che.IsChecked = false;
                _rightCheckbox_che.IsChecked = false;
            }
        }
        #endregion
        
        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
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
            e.Handled = Tools.ValidateTextFloat(sender, e);
        }
        
        /// <summary>
        /// Description: Envía el valor configurado para el procedimiento
        /// </summary>
        private void _textValue_tex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textValue_tex.Text != "")
                {
                    float fuelQty = 0;

                    if (float.TryParse(_textValue_tex.Text, out fuelQty) == false)
                    {
                        _textValue_tex.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect value",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        if (fuelQty <= 160)
                        {
                            Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Fuel Qty").First();
                            procedure procedure = procedures.Procedure;

                            if (_leftCheckbox_che.IsChecked == true)
                            {
                                procedures.IsChecked = true;
                                procedures.Value = _textValue_tex.Text;

                                //Logic send procedure Left
                            }
                            else
                            {
                                if (_rightCheckbox_che.IsChecked == true)
                                {
                                    procedures.IsChecked = true;
                                    procedures.Value = _textValue_tex.Text;

                                    //Logic send procedure Right
                                }
                                else
                                {
                                    if (_bothCheckbox_che.IsChecked == true)
                                    {
                                        procedures.IsChecked = true;
                                        procedures.Value = _textValue_tex.Text;

                                        //Logic send procedure Both
                                    }
                                    else
                                    {
                                        RadWindow.Alert(new DialogParameters
                                        {
                                            Header = "Alert",
                                            Content = "Select a option and send Value",
                                            OkButtonContent = "Ok",
                                            Owner = this
                                        });
                                    }
                                }
                            }

                            if (_leftCheckbox_che.IsChecked == true || _rightCheckbox_che.IsChecked == true || _bothCheckbox_che.IsChecked == true)
                            {
                                RadWindow.Alert(new DialogParameters
                                {
                                    Header = "Alert",
                                    Content = "Value sent",
                                    OkButtonContent = "Ok",
                                    Owner = this
                                });

                                Keyboard.ClearFocus();
                            }
                        }
                        else
                        {
                            _textValue_tex.Text = "0";
                            RadWindow.Alert(new DialogParameters
                            {
                                Header = "Alert",
                                Content = "160 gal max",
                                OkButtonContent = "Ok",
                                Owner = this
                            });
                        }
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete value field and send Value",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Envía el procedimiento de perdida de combustible en el tanque seleccionado
        /// </summary>
        private void _comboParameter_com_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Fuel leak").First();
            procedures.IsChecked = true;
            procedure procedure = procedures.Procedure;

            //Logic send procedure

            RadWindow.Alert(new DialogParameters
            {
                Header = "Alert",
                Content = "Value sent",
                OkButtonContent = "Ok",
                Owner = this
            });
        }
    }
}
