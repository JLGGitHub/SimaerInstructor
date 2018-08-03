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
        public int _initParameter_str = 0;
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
        /// Description: Carga el combo box inicial
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _comboParameter_com.SelectedIndex = _initParameter_str;
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

        #region Evento botones
        /// <summary>
        /// Description: Toggle now y programmed
        /// </summary>
        private void _nowButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if(_nowButton_btn.IsChecked == true)
            {
                _programmedButton_btn.IsChecked = false;
            }
            else
            {
                _programmedButton_btn.IsChecked = true;
            }
        }

        /// <summary>
        /// Description: Toggle now y programmed
        /// </summary>
        private void _programmedButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_programmedButton_btn.IsChecked == true)
            {
                _nowButton_btn.IsChecked = false;
            }
            else
            {
                _nowButton_btn.IsChecked = true;
            }
        }

        /// <summary>
        /// Description: Inicia el procedimiento
        /// </summary>
        private void _startButton_btn_Click(object sender, RoutedEventArgs e)
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
                    Content = "Complete all fields and press Start",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion
    }
}
