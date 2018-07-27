using System;
using System.Collections.Generic;
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
            _iconPlaying.Source = new BitmapImage(new Uri(iconsFullPath + "play.png"));
            _iconClose_img.Source = new BitmapImage(new Uri(iconsFullPath + "exit.png"));

            _bottomNavigation_use.SetCollapsedButtons(2, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.parentWindow_wty = WindowsType.MainWindow;
        }

        /// <summary>
        /// Description: Cada vez que cambie el tamaño de la pantalla siempre la configura a FullHD
        /// </summary>
        private void ChangedEvent(object sender, SizeChangedEventArgs e)
        {
            this.Height = 1080.0;
            this.Width = 1920.0;
        }
    }
}
