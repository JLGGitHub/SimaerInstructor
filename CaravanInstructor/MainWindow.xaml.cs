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
using CaravanInstructor.Classes.Pilot;
using CaravanInstructor.Views.ScenarioUI;
using CaravanInstructor.Views.Select;
using Telerik.Windows.Controls;

namespace CaravanInstructor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Variables
        private static ObservableCollection<Scenario> _scenarios_sce = new ObservableCollection<Scenario>();
        private static ObservableCollection<Pilot> _pilots_pil = new ObservableCollection<Pilot>();
        private static ObservableCollection<Grade> _grades_gra = new ObservableCollection<Grade>();
        #endregion

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

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "home.png"));

            _bottomNavigation_use.SetCollapsedButtons(2, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.MainWindow;
            _bottomNavigation_use.ParentWindow_win = this;
        }

        internal void InitData()
        {
            Scenario scenario;

            scenario = new Scenario(0, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(0, "Día", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            scenario = new Scenario(1, "Rio negro");
            scenario.RunWayTolID_run = new RunwayTol(0, "Short Field");
            scenario.TimeDayID_tim = new TimeDay(1, "Noche", new DateTime());
            _scenarios_sce.Add(scenario);

            Grade grade;

            grade = new Grade(0, "Sin rango", "NN");
            _grades_gra.Add(grade);

            grade = new Grade(1, "Técnico Junior", "TJ");
            _grades_gra.Add(grade);

            grade = new Grade(2, "Rango 2", "R2");
            _grades_gra.Add(grade);

            grade = new Grade(3, "Rango 3", "R3");
            _grades_gra.Add(grade);

            grade = new Grade(4, "Rango 4", "R4");
            _grades_gra.Add(grade);

            Pilot pilot;

            pilot = new Pilot(11218934, "Yenner", "Robayo");
            pilot.GradeID_gra = _grades_gra[0];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(325351, "hfahds", "dsfhdfhd");
            pilot.GradeID_gra = _grades_gra[1];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(43673, "fhs", "rehreh");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(34653735, "fdbdbd", "rehrdf");
            pilot.GradeID_gra = _grades_gra[3];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(52351, "hrrehrdfnb", "fbnene");
            pilot.GradeID_gra = _grades_gra[4];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "enener", "erhrehren");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(325351, "yjty", "herhet");
            pilot.GradeID_gra = _grades_gra[1];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(43673, "ntene", "bwrh");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(34653735, "nvnc", "dgweg");
            pilot.GradeID_gra = _grades_gra[3];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(52351, "hrh", "yjykjt");
            pilot.GradeID_gra = _grades_gra[4];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "ngnv", "jhtejr");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "enener", "erhrehren");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(325351, "yjty", "herhet");
            pilot.GradeID_gra = _grades_gra[1];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(43673, "ntene", "bwrh");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(34653735, "nvnc", "dgweg");
            pilot.GradeID_gra = _grades_gra[3];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(52351, "hrh", "yjykjt");
            pilot.GradeID_gra = _grades_gra[4];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "ngnv", "jhtejr");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(43673, "ntene", "bwrh");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(34653735, "nvnc", "dgweg");
            pilot.GradeID_gra = _grades_gra[3];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(52351, "hrh", "yjykjt");
            pilot.GradeID_gra = _grades_gra[4];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "ngnv", "jhtejr");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "enener", "erhrehren");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(325351, "yjty", "herhet");
            pilot.GradeID_gra = _grades_gra[1];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(43673, "ntene", "bwrh");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(34653735, "nvnc", "dgweg");
            pilot.GradeID_gra = _grades_gra[3];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(52351, "hrh", "yjykjt");
            pilot.GradeID_gra = _grades_gra[4];
            _pilots_pil.Add(pilot);

            pilot = new Pilot(67806, "ngnv", "jhtejr");
            pilot.GradeID_gra = _grades_gra[2];
            _pilots_pil.Add(pilot);
        }

        #region Eventos botones
        /// <summary>
        /// Description: Abre interfaz para seleccionar instructor y piloto
        /// </summary>
        private void _buttonSelect_btn_Click(object sender, RoutedEventArgs e)
        {
            SelectInstructor selectInstructor = new SelectInstructor(this);
            selectInstructor.Show();
            this.Hide();
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

        internal static ObservableCollection<Scenario> GetScenarios()
        {
            return _scenarios_sce;
        }

        internal static ObservableCollection<Pilot> GetPilots()
        {
            return _pilots_pil;
        }

        internal static ObservableCollection<Grade> GetGrades()
        {
            return _grades_gra;
        }

        internal static void AddPilot(Pilot i_pilot)
        {
            _pilots_pil.Add(i_pilot);
        }

        internal static void EditPilots(Pilot i_pilot)
        {
            Pilot queryPilot = _pilots_pil.Where<Pilot>(pilot => pilot.MilitarCode_int == i_pilot.MilitarCode_int).FirstOrDefault();

            if(queryPilot != null)
            {
                _pilots_pil[(_pilots_pil.IndexOf(queryPilot))] = i_pilot;
            }
            else
            {
                AddPilot(i_pilot);
            }
        }

        internal static void RemovePilot(Pilot i_pilot)
        {
            Pilot queryPilot = _pilots_pil.Where<Pilot>(pilot => pilot.MilitarCode_int == i_pilot.MilitarCode_int).FirstOrDefault();

            if (queryPilot != null)
            {
                _pilots_pil.Remove(queryPilot);
            }
        }
    }
}
