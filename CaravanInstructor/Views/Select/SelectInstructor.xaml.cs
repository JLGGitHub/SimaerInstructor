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
using CaravanInstructor.Classes;
using CaravanInstructor.Database;
using CaravanInstructor.Logic;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace CaravanInstructor.Views.Select
{
    /// <summary>
    /// Lógica de interacción para SelectInstructor.xaml
    /// </summary>
    public partial class SelectInstructor : Window
    {
        #region Variables
        private MainWindow _parent_win;
        public List<pilot> Pilots { get; set; }
        #endregion

        public SelectInstructor(MainWindow i_parent)
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
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "pilot.png"));

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "ui.png"));

            _bottomNavigation_use.SetCollapsedButtons(0, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.SelectInstructor;
            _bottomNavigation_use.ParentWindow_win = this;
        }

        /// <summary>
        /// Description: Obtiene los datos de la base de datos
        /// </summary>
        private void GetData()
        {
            DataContext = this;

            PilotLogic pilotLogic = new PilotLogic();
            Pilots = pilotLogic.ReadPilots();
        }

        #region Eventos botones
        /// <summary>
        /// Description: Valida la selección de un instructor
        /// </summary>
        private void _nextButton_btn_Click(object sender, RoutedEventArgs e)
        {
            pilot pilotSelected = _pilotGridView_rgv.SelectedItem as pilot;

            if (pilotSelected != null)
            {
                SelectStudent selectStudent = new SelectStudent(this);
                selectStudent.Show();
                this.Hide();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Select instructor and press next",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion

        /// <summary>
        /// Description: Muestra home y finaliza la selección de instructor y estudiante
        /// </summary>
        public void FinishSelect()
        {
            _parent_win.Show();
            this.Close();
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

        /// <summary>
        /// Description: Muestra la ventana new pilot
        /// </summary>
        private void _newPilotButton_btn_Click(object sender, RoutedEventArgs e)
        {
            NewPilot newPilot = new NewPilot();
            newPilot.ShowDialog();
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

    /// <summary>
    /// Description: Clase para capturar los eventos de delete y edit
    /// </summary>
    public class ButtonViewModel
    {
        public ICommand DeleteCommand { get; set; }
        public ICommand EditCommand { get; set; }

        private pilot _pilotDelete_pit;

        public ButtonViewModel()
        {
            this.DeleteCommand = new DelegateCommand(OnDeleteCommandExecuted);
            this.EditCommand = new DelegateCommand(OnEditCommandExecuted);
        }

        /// <summary>
        /// Description: Evento delete
        /// </summary>
        private void OnDeleteCommandExecuted(object obj)
        {
            var row = obj as GridViewRow;
            pilot item = row.DataContext as pilot;

            if (item != null)
            {
                _pilotDelete_pit = item;

                RadWindow.Confirm(new DialogParameters
                {
                    Header = "Confirm",
                    Content = "Are you sure you want to delete a pilot?",
                    CancelButtonContent = "Cancel",
                    OkButtonContent = "Ok",
                    Closed = new EventHandler<WindowClosedEventArgs>(OnConfirmDelete),
                    Owner = Application.Current.MainWindow
                });
            }
        }

        /// <summary>
        /// Description: Valida la confirmación de borrar el piloto
        /// </summary>
        private void OnConfirmDelete(object sender, WindowClosedEventArgs e)
        {
            if (e.DialogResult == true)
            {
                //DELETE _pilotDelete_pit
            }
        }

        /// <summary>
        /// Description: Evento edit
        /// </summary>
        private void OnEditCommandExecuted(object obj)
        {
            var row = obj as GridViewRow;
            pilot item = row.DataContext as pilot;

            if (item != null)
            {
                NewPilot newPilot = new NewPilot(true);
                newPilot._textMilitarCode_tex.Text = item.militar_code;
                newPilot._textFirstName_tex.Text = item.first_name;
                newPilot._textLastName_tex.Text = item.last_name;
                //newPilot._comboGrade_com.SelectedItem = item.grade;
                newPilot.ShowDialog();
            }
        }
    }

    /// <summary>
    /// Description: Clase para enviar por binding el fondo del botón delete
    /// </summary>
    public class ConverterDelete : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Description: Envía la imagen delete de acuerto a la configuración
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            return new BitmapImage(new Uri(iconsFullPath + "delete.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Binding.DoNothing;
        }

        #endregion
    }

    /// <summary>
    /// Description: Clase para enviar por binding el fondo del botón edit
    /// </summary>
    public class ConverterEdit : IValueConverter
    {
        #region IValueConverter Members

        /// <summary>
        /// Description: Envía la imagen edit de acuerto a la configuración
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            return new BitmapImage(new Uri(iconsFullPath + "edit.png"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return Binding.DoNothing;
        }

        #endregion
    }
}
