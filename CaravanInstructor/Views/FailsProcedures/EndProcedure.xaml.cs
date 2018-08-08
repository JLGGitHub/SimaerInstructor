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
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.FailsProcedures
{
    /// <summary>
    /// Interaction logic for EndProcedure.xaml
    /// </summary>
    public partial class EndProcedure : Window
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

        public EndProcedure(UserControl i_parent)
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

        #region Evento botones
        /// <summary>
        /// Description: Guarda el comentario del procedimiento finalizado
        /// </summary>
        private void _saveButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_textComment_tex.Text != "")
            {
                if (_parent_win != null)
                {
                    switch (_parentType_wty)
                    {
                        case UserControlsType.ListFailsProceduresType1:
                            ((UserControls.ListFailsProceduresType1)_parent_win).ConfirmEndProcedure(_textComment_tex.Text);
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
                    Content = "Complete comments field and press Save",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion

        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textComment_tex_TextChanged(object sender, TextChangedEventArgs e)
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
    }
}
