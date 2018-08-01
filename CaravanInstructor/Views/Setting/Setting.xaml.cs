using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
using CaravanInstructor.Classes;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.Setting
{
    /// <summary>
    /// Interaction logic for Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        private Window _parent_win;
        private bool _isConnected_boo = false;

        public Setting(Window i_parent)
        {
            InitializeComponent();
            _parent_win = i_parent;

            SetInitConfigWindow();
            ValidateConnection();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "settings.png"));

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "ui.png"));

            string imagesFullPath = Tools.GetImagesFullPath();
            _imageNetwork_img.Source = new BitmapImage(new Uri(imagesFullPath + "network.png"));

            _bottomNavigation_use.SetCollapsedButtons(0, 2, 2, 2, 2, 2, 2, 2, 2);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.Setting;
            _bottomNavigation_use.ParentWindow_win = this;

            _textMyAddress_tex.Text = GetLocalIPAddress();
            _textServerAddress_tex.Text = Properties.Settings.Default.ServerAddress;
            _textServerPort_tex.Text = Properties.Settings.Default.ServerPort;
        }

        /// <summary>
        /// Description: Cuando se cierra la ventana muestra al padre
        /// </summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _parent_win.Show();
        }

        /// <summary>
        /// Description: Muestra al padre y cierra la ventana
        /// </summary>
        public void BackButton()
        {
            _parent_win.Show();
            this.Close();
        }

        #region Evento botones
        /// <summary>
        /// Description: Configuración de red por defecto y verifica conexión
        /// </summary>
        private void _defaultButton_btn_Click(object sender, RoutedEventArgs e)
        {
            _textServerAddress_tex.Text = Properties.Settings.Default.ServerAddress;
            _textServerPort_tex.Text = Properties.Settings.Default.ServerPort;

            ValidateConnection();
        }

        /// <summary>
        /// Description: Conecta con el servidor
        /// </summary>
        private void _connectButton_btn_Click(object sender, RoutedEventArgs e)
        {
            if (_isConnected_boo == false)
            {
                if ((_textServerAddress_tex.Text != "") && (_textServerPort_tex.Text != ""))
                {
                    ValidateConnection();
                }
                else
                {
                    RadWindow.Alert(new DialogParameters
                    {
                        Header = "Alert",
                        Content = "Complete all fields and press connect",
                        OkButtonContent = "Ok",
                        Owner = this
                    });
                }
            }
            else
            {
                Disconnect();
            }
        }
        #endregion

        /// <summary>
        /// Description: Obtiene la ip local
        /// </summary>
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "No network adapters";
        }

        /// <summary>
        /// Description: Verifica la conexión con el servidor
        /// </summary>
        private void ValidateConnection()
        {
            bool check = false;

            //Validar conexión para setear booleano
            check = true;

            if (check == true)
            {
                Properties.Settings.Default.ServerAddress = _textServerAddress_tex.Text;
                Properties.Settings.Default.ServerPort = _textServerPort_tex.Text;
                Properties.Settings.Default.Save();

                _toggleStatus_btn.IsChecked = check;
                _isConnected_boo = true;
                _connectButton_btn.Content = "Disconnect";
                _textServerAddress_tex.IsEnabled = false;
                _textServerPort_tex.IsEnabled = false;
                _defaultButton_btn.IsEnabled = false;
            }
            else
            {

            }
        }

        /// <summary>
        /// Description: Desconecta con el servido
        /// </summary>
        private void Disconnect()
        {
            _toggleStatus_btn.IsChecked = false;
            _isConnected_boo = false;
            _connectButton_btn.Content = "Connect";
            _textServerAddress_tex.IsEnabled = true;
            _textServerPort_tex.IsEnabled = true;
            _defaultButton_btn.IsEnabled = true;
        }

        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void _textServerAddress_tex_TextChanged(object sender, TextChangedEventArgs e)
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
        private void _textServerPort_tex_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Description: Evento que se ejecuta antes de ingresar la tecla, valida si es un digito
        /// </summary>
        private void _textServerPort_tex_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
