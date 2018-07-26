using System;
using System.IO;
using System.Windows;
using System.Windows.Threading;
using CaravanInstructor.Views.Splash;

namespace CaravanInstructor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DispatcherTimer timer;
        public Splash splash;

        /// <summary>
        /// Description: Evento que se ejecuta al iniciar la aplicación. 
        /// Activar un evento global de excepciones, visualiza el Splash y activa un timer para visualizar la ventana principal.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            Application.Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;

            splash = new Splash();
            splash.Show();

            base.OnStartup(e);

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(4);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        /// <summary>
        /// Description: Visualiza la ventana principal y cierra el Splash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            MainWindow main = new MainWindow();
            splash.Close();
            timer.Stop();
            main.Show();
        }

        /// <summary>
        /// Description: Obtiene las excepciones de la aplicación y las almacena en un Log.
        /// Finaliza la ejecución de la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            e.Handled = true;
            LogFile(e.Exception.Data.ToString, e.Exception.HResult, e.Exception.Message, e.Exception.Source, e.Exception.StackTrace, e.Exception.TargetSite);
            Application.Current.Shutdown();
        }

        /// <summary>
        /// Description: Crea o añade cada una de las excepciones al Log
        /// </summary>
        /// <param name="func"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="p5"></param>
        /// <param name="methodBase"></param>
        private static void LogFile(Func<string> func, int p2, string p3, string p4, string p5, System.Reflection.MethodBase methodBase)
        {
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }

            // Write to the file:
            log.WriteLine("Data Time:" + DateTime.Now);
            log.WriteLine("Exception Data:" + func);
            log.WriteLine("HResult:" + p2);
            log.WriteLine("Message:" + p3);
            log.WriteLine("Source:" + p4);
            log.WriteLine("StackTrace:" + p5);
            log.WriteLine("Form Name:" + methodBase.ToString());
            log.Close();
        }
    }
}
