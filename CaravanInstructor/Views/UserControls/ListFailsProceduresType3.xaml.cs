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
using Telerik.Windows.Controls;
using CaravanInstructor.Model;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ListFailsProceduresType3.xaml
    /// </summary>
    public partial class ListFailsProceduresType3 : UserControl
    {
        #region Variables
        public List<Procedures> SelectFailsProcedures { get; set; }
        private SystemsCaravan AllFailsProceduresSystem { get; set; }
        #endregion

        public ListFailsProceduresType3()
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

        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textZone_txt_TextChanged(object sender, TextChangedEventArgs e)
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
        private void _textZone_txt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Tools.ValidateTextFloat(sender, e);
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone1_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone1_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone1_txt.Text, out value) == false)
                    {
                        _textZone1_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone1
                        
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone2_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone2_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone2_txt.Text, out value) == false)
                    {
                        _textZone2_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone2

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone3_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone3_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone3_txt.Text, out value) == false)
                    {
                        _textZone3_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone3

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone4_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone4_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone4_txt.Text, out value) == false)
                    {
                        _textZone4_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone4

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone5_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone5_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone5_txt.Text, out value) == false)
                    {
                        _textZone5_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone5

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZone6_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZone6_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone6_txt.Text, out value) == false)
                    {
                        _textZone6_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure Zone6

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZoneA_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZoneA_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZone6_txt.Text, out value) == false)
                    {
                        _textZone6_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure ZoneA

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZoneB_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZoneB_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZoneB_txt.Text, out value) == false)
                    {
                        _textZoneB_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure ZoneB

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZoneC_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZoneC_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZoneB_txt.Text, out value) == false)
                    {
                        _textZoneB_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure ZoneC

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Activa el procedimiento correspondiente con el parametro digitado
        /// </summary>
        private void _textZoneD_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (_textZoneD_txt.Text != "")
                {
                    float value = 0;
                    if (float.TryParse(_textZoneD_txt.Text, out value) == false)
                    {
                        _textZoneD_txt.Text = "0";
                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Incorrect pounds",
                            OkButtonContent = "Ok",
                            Owner = this
                        });
                    }
                    else
                    {
                        Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
                        procedure procedure = procedures.Procedure;

                        //Logic send procedure ZoneD

                        RadWindow.Alert(new DialogParameters
                        {
                            Header = "Alert",
                            Content = "Pounds sent",
                            OkButtonContent = "Ok",
                            Owner = this
                        });

                        Keyboard.ClearFocus();
                    }
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete field and send Pounds",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
        }

        /// <summary>
        /// Description: Limpia cada uno de los valores del procedimiento
        /// </summary>
        private void _clearButton_btn_Click(object sender, RoutedEventArgs e)
        {
            Procedures procedures = SelectFailsProcedures.Where<Procedures>(wprocedure => wprocedure.Procedure.name == "Weight and Balance").First();
            procedure procedure = procedures.Procedure;

            //Logic clear procedures

            _textZone1_txt.Text = "";
            _textZone2_txt.Text = "";
            _textZone3_txt.Text = "";
            _textZone4_txt.Text = "";
            _textZone5_txt.Text = "";
            _textZone6_txt.Text = "";
            _textZoneA_txt.Text = "";
            _textZoneB_txt.Text = "";
            _textZoneC_txt.Text = "";
            _textZoneD_txt.Text = "";

            RadWindow.Alert(new DialogParameters
            {
                Header = "Alert",
                Content = "Pounds cleared",
                OkButtonContent = "Ok",
                Owner = this
            });
        }
    }
}
