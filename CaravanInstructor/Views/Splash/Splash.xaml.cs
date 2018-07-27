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
            _labelProduct_lbl.FontSize = sizeFontSplash;
            _labelClient_lbl.FontSize = sizeFontSplash;
            _labelCodaltec_lbl.FontSize = sizeFontSplash;
            _labelReservedRights_lbl.FontSize = sizeFontSplash;
        }
    }
}
