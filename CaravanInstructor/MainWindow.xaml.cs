using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CaravanInstructor.Classes;
using CaravanInstructor.Classes.Scenario;
using CaravanInstructor.Views.ScenarioUI;
using Telerik.Windows.Controls;

namespace CaravanInstructor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetInitConfigWindow();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "home.png"));
            _iconSelect_img.Source = new BitmapImage(new Uri(iconsFullPath + "pilot.png"));
            _iconScenario_img.Source = new BitmapImage(new Uri(iconsFullPath + "world.png"));
            _iconPlay_img.Source = new BitmapImage(new Uri(iconsFullPath + "play.png"));
            _iconClose_img.Source = new BitmapImage(new Uri(iconsFullPath + "exit.png"));

            _bottomNavigation_use.SetCollapsedButtons(2, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindow_wty = WindowsType.MainWindow;
        }

        /// <summary>
        /// Description: Cada vez que cambie el tamaño de la pantalla siempre la configura a FullHD
        /// </summary>
        private void ChangedEvent(object sender, SizeChangedEventArgs e)
        {
            this.Height = 1080.0;
            this.Width = 1920.0;
        }

        #region Eventos botones
        /// <summary>
        /// Description: Abre interfaz para seleccionar instructor y piloto
        /// </summary>
        private void _buttonSelect_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Description: Abre interfaz para seleccionar escenario
        /// </summary>
        private void _buttonScenario_btn_Click(object sender, RoutedEventArgs e)
        {
            ScenarioUI scenarioUI = new ScenarioUI(this);
            scenarioUI.Show();
            this.Hide();
        }

        /// <summary>
        /// Description: Abre interfaz para iniciar la simulación
        /// </summary>
        private void _buttonPlay_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Description: Crea alerta para confirmar cierre de la aplicación
        /// </summary>
        private void _buttonClose_btn_Click(object sender, RoutedEventArgs e)
        {
            RadWindow.Confirm(new DialogParameters
            {
                Header = "Confirm",
                Content = "Are you sure you want to close application?",
                CancelButtonContent = "Cancel",
                OkButtonContent = "Ok",
                Closed = new EventHandler<WindowClosedEventArgs>(OnConfirmClosed),
                Owner = Application.Current.MainWindow
            });
        }

        /// <summary>
        /// Description: Valida la confirmación del cierre de la aplicación
        /// </summary>
        private void OnConfirmClosed(object sender, WindowClosedEventArgs e)
        {
            if (e.DialogResult == true)
            {
                Application.Current.Shutdown();
            }
        }
        #endregion
    }
}
