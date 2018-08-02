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
using CaravanInstructor.Class;
using CaravanInstructor.Model;
using CaravanInstructor.Logic;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.ScenarioUI
{
    /// <summary>
    /// Lógica de interacción para Scenario.xaml
    /// </summary>
    public partial class ScenarioUI : Window
    {
        #region Variables
        private MainWindow _parent_win;
        public List<scenario> Scenarios { get; set; }
        #endregion

        public ScenarioUI(MainWindow i_parent)
        {
            InitializeComponent();
            _parent_win = i_parent;

            SetInitConfigWindow();
            GetData();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "world.png"));

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "ui.png"));

            _bottomNavigation_use.SetCollapsedButtons(0, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.Scenario;
            _bottomNavigation_use.ParentWindow_win = this;
        }

        /// <summary>
        /// Description: Obtiene los datos de la base de datos
        /// </summary>
        private void GetData()
        {
            DataContext = this;

            ScenarioLogic scenarioLogic = new ScenarioLogic();
            Scenarios = scenarioLogic.ReadScenarios();
        }

        #region Eventos botones
        /// <summary>
        /// Description: Valida la selección de un escenario
        /// </summary>
        private void _finishButton_btn_Click(object sender, RoutedEventArgs e)
        {
            scenario scenarioSelected = _scenarioGridView_rgv.SelectedItem as scenario;

            if (scenarioSelected != null)
            {
                _parent_win.Show();
                this.Close();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Select scenario and press finish",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion

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
    }
}
