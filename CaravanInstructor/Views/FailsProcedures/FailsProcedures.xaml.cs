using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using CaravanInstructor.Logic;
using CaravanInstructor.Model;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.FailsProcedures
{
    /// <summary>
    /// Interaction logic for FailsProcedures.xaml
    /// </summary>
    public partial class FailsProcedures : Window
    {
        private MainWindow _parent_win;

        public List<system> SystemsCaravan { get; set; }
        
        public FailsProcedures(MainWindow i_parent)
        {
            InitializeComponent();

            _parent_win = i_parent;

            SetInitConfigWindow();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            string iconsFullPath = Tools.GetIconsFullPath();
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "play.png"));

            string backgroundsFullPath = Tools.GetBackgroundsFullPath();
            _imageWindow_img.ImageSource = new BitmapImage(new Uri(backgroundsFullPath + "ui.png"));
            
            _bottomNavigation_use.SetCollapsedButtons(0, 2, 0, 0, 0, 0, 0, 0, 0);
            _bottomNavigation_use.ParentWindowType_wty = WindowsType.FailProcedures;
            _bottomNavigation_use.ParentWindow_win = this;

            this.DataContext = this;

            SystemsCaravan = new List<system>();

            SystemLogic systemLogic = new SystemLogic();
            SystemsCaravan = systemLogic.ReadSystems();

            foreach (var item in SystemsCaravan)
            {
                item.InitCategories();
            }
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
    }
}
