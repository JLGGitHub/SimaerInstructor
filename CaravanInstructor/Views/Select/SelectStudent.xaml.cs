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

namespace CaravanInstructor.Views.Select
{
    /// <summary>
    /// Lógica de interacción para SelectInstructor.xaml
    /// </summary>
    public partial class SelectStudent : Window
    {
        #region Variables
        private SelectInstructor _parent_win;
        public List<pilot> Pilots { get; set; }
        private PilotLogic pilotLogic;
        public static SelectStudent instance;
        #endregion

        public SelectStudent(SelectInstructor i_parent)
        {
            InitializeComponent();
            _parent_win = i_parent;

            SetInitConfigWindow();
            GetData();

            instance = this;
        }

        /// <summary>
        /// Description: Obtiene los datos de la base de datos
        /// </summary>
        private void GetData()
        {
            DataContext = this;

            pilotLogic = new PilotLogic();
            Pilots = pilotLogic.ReadPilots();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "pilot.png"));

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "ui.png"));

            _bottomNavigation_use.SetCollapsedButtons(0, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.SelectStudent;
            _bottomNavigation_use.ParentWindow_win = this;
        }

        #region Eventos botones
        /// <summary>
        /// Description: Valida la selección de un estudiante
        /// </summary>
        private void _finishButton_btn_Click(object sender, RoutedEventArgs e)
        {
            pilot pilotSelected = _pilotGridView_rgv.SelectedItem as pilot;

            if (pilotSelected != null)
            {
                this.Close();
                _parent_win.FinishSelect();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Select student and press next",
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
            instance = null;
        }

        /// <summary>
        /// Description: Muestra al padre y cierra la ventana
        /// </summary>
        public void BackButton()
        {
            _parent_win.Show();
            this.Close();
        }

        /// <summary>
        /// Description: Muestra la ventana new pilot
        /// </summary>
        private void _newPilotButton_btn_Click(object sender, RoutedEventArgs e)
        {
            NewPilot newPilot = new NewPilot();
            newPilot.ShowDialog();
        }

        /// <summary>
        /// Description: Actualiza la información en la tabla
        /// </summary>
        public void UpdateData()
        {
            Pilots = pilotLogic.ReadPilots();
            _pilotGridView_rgv.ItemsSource = Pilots;
            _pilotGridView_rgv.Items.Refresh();
        }

        /// <summary>
        /// Description: Si no hay texto ingresado cambia el color de letra a gris claro, en caso contrario lo deja en negro
        /// </summary>
        private void PART_SearchAsYouTypeTextBox_TextChanged(object sender, TextChangedEventArgs e)
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
