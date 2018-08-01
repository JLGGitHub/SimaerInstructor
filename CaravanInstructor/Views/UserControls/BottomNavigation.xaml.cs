using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using CaravanInstructor.Classes;
using CaravanInstructor.Views;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BottomNavigation.xaml
    /// </summary>
    public partial class BottomNavigation : UserControl
    {
        #region Variables
        WindowsType _parentWindowType_wty = WindowsType.None;
        Window _parentWindow_win;
        #endregion

        #region Getters y Setters
        public WindowsType ParentWindowType_wty
        {
            get
            {
                return this._parentWindowType_wty;
            }
            set
            {
                this._parentWindowType_wty = value;
            }
        }

        public Window ParentWindow_win
        {
            get
            {
                return this._parentWindow_win;
            }
            set
            {
                this._parentWindow_win = value;
            }
        }
        #endregion

        public BottomNavigation()
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
            _imageBack_img.Source = new BitmapImage(new Uri(iconsFullPath + "back.png"));
            _imagePlay_img.Source = new BitmapImage(new Uri(iconsFullPath + "play.png"));
            _imageMap_img.Source = new BitmapImage(new Uri(iconsFullPath + "map.png"));
            _imageQuickStart_img.Source = new BitmapImage(new Uri(iconsFullPath + "quick_start.png"));
            _imageScheduled_img.Source = new BitmapImage(new Uri(iconsFullPath + "scheduled.png"));
            _imageReport_img.Source = new BitmapImage(new Uri(iconsFullPath + "report.png"));
            _imageHome_img.Source = new BitmapImage(new Uri(iconsFullPath + "home.png"));
            _imagePause_img.Source = new BitmapImage(new Uri(iconsFullPath + "pause.png"));
            _imageSettings_img.Source = new BitmapImage(new Uri(iconsFullPath + "settings.png"));
        }

        /// <summary>
        /// Description: Esconde los botones de la barra inferior de navegación de acuerdo a las entradas
        /// 0 Visible, 1 Hidden, 2 Collapsed
        /// </summary>
        /// <param name="i_buttonBack"></param>
        /// <param name="i_buttonPlay"></param>
        /// <param name="i_buttonMap"></param>
        /// <param name="i_buttonQuickStart"></param>
        /// <param name="i_buttonScheduled"></param>
        /// <param name="i_buttonReport"></param>
        /// <param name="i_buttonHome"></param>
        /// <param name="i_buttonPause"></param>
        /// <param name="i_buttonSeettings"></param>
        public void SetCollapsedButtons(int i_buttonBack, int i_buttonPlay, int i_buttonMap, int i_buttonQuickStart, int i_buttonScheduled,
            int i_buttonReport, int i_buttonHome, int i_buttonPause, int i_buttonSeettings)
        {
            _buttonBack_btn.Visibility = (Visibility)i_buttonBack;
            _buttonPlay_btn.Visibility = (Visibility)i_buttonPlay;
            _buttonMap_btn.Visibility = (Visibility)i_buttonMap;
            _buttonQuickStart_btn.Visibility = (Visibility)i_buttonQuickStart;
            _buttonScheduled_btn.Visibility = (Visibility)i_buttonScheduled;
            _buttonReport_btn.Visibility = (Visibility)i_buttonReport;
            _buttonHome_btn.Visibility = (Visibility)i_buttonHome;
            _buttonPause_btn.Visibility = (Visibility)i_buttonPause;
            _buttonSettings_btn.Visibility = (Visibility)i_buttonSeettings;
        }

        #region Eventos botones de la barra de navegación
        private void _buttonBack_btn_Click(object sender, RoutedEventArgs e)
        {
            if(_parentWindow_win != null)
            {
                switch(_parentWindowType_wty)
                {
                    case WindowsType.MainWindow:
                        break;
                    case WindowsType.SelectInstructor:
                        ((Select.SelectInstructor)_parentWindow_win).BackButton();
                        break;
                    case WindowsType.SelectStudent:
                        ((Select.SelectStudent)_parentWindow_win).BackButton();
                        break;
                    case WindowsType.Scenario:
                        ((ScenarioUI.ScenarioUI)_parentWindow_win).BackButton();
                        break;
                    default:
                        break;
                }
            }
        }
        
        private void _buttonMap_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonPlay_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonQuickStart_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonScheduled_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonReport_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonHome_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonPause_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _buttonSettings_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
