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
using System.Windows.Shapes;
using Telerik.Windows.Controls;
using CaravanInstructor.Class;
using CaravanInstructor.Views.UserControls;
using System.Text.RegularExpressions;

namespace CaravanInstructor.Views.FailsProcedures
{
    /// <summary>
    /// Interaction logic for ActivateProcedure.xaml
    /// </summary>
    public partial class ActivateProcedure : Window
    {
        #region Variables
        private UserControl _parent_win;
        UserControlsType _parentType_wty = UserControlsType.None;
        #endregion

        #region Getters y Setters
        public UserControlsType ParentType_wty
        {
            get
            {
                return this._parentType_wty;
            }
            set
            {
                this._parentType_wty = value;
            }
        }
        #endregion

        public ActivateProcedure(UserControl i_parent)
        {
            InitializeComponent();

            _parent_win = i_parent;
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
        /// Description: Cierra la ventana
        /// </summary>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            if (_parent_win != null)
            {
                switch (_parentType_wty)
                {
                    case UserControlsType.ListFailsProceduresType1:
                        ((UserControls.ListFailsProceduresType1)_parent_win).ConfirmStartProcedure(false);
                        break;
                    default:
                        break;
                }
            }

            this.Close();
        }

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

        #region Evento botones

        /// <summary>
        /// Description: Inicia el procedimiento sin parametros
        /// </summary>
        private void _nowButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_parent_win != null)
            {
                switch (_parentType_wty)
                {
                    case UserControlsType.ListFailsProceduresType1:
                        ((UserControls.ListFailsProceduresType1)_parent_win).ConfirmStartProcedure(true);
                        break;
                    default:
                        break;
                }
            }

            this.Close();
        }

        /// <summary>
        /// Description: Inicia el procedimiento con parametros
        /// </summary>
        private void _programmedButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_textValue_tex.Text != "")
            {
                //Lógica send procedure

                if (_parent_win != null)
                {
                    switch (_parentType_wty)
                    {
                        case UserControlsType.ListFailsProceduresType1:
                            ((UserControls.ListFailsProceduresType1)_parent_win).ConfirmStartProcedure(true);
                            break;
                        default:
                            break;
                    }
                }

                this.Close();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Complete value field and press Programmed",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion
    }
}
