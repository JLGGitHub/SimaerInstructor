using System.Windows;

namespace CaravanInstructor.Views.Splash
{
    /// <summary>
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        public Splash()
        {
            InitializeComponent();

            SetInitConfigWindow();
        }

        /// <summary>
        /// Description: Realiza la configuración inicial de la interfaz gráfica según las variables de configuración
        /// </summary>
        private void SetInitConfigWindow()
        {
            int sizeFontSplash = Properties.Settings.Default.FontSizeSplash;
            labelProduct.FontSize = sizeFontSplash;
            labelClient.FontSize = sizeFontSplash;
            labelCodaltec.FontSize = sizeFontSplash;
            labelReservedRights.FontSize = sizeFontSplash;
        }
    }
}
