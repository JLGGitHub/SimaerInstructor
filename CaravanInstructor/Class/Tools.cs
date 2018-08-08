using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CaravanInstructor.Class
{
    /// <summary>
    /// Description: Enumerador para indicar el tipo de interfaz
    /// </summary>
    public enum WindowsType
    {
        MainWindow,
        SelectInstructor,
        SelectStudent,
        Scenario,
        FailProcedures,
        Setting,
        None
    }

    public enum UserControlsType
    {
        ListFailsProceduresType1,
        None
    }

    public enum EnumSystemsType
    {
        FlightControls = 1,
        Engine,
        Fire,
        Fuel,
        Electrical,
        Miscellaneus,
        Avionics,
        IceProtection
    }

    public enum EnumProceduresType
    {
        Abnormal = 1,
        Emergency,
        Failure
    }

    class Tools
    {
        /// <summary>
        /// Description: Retorna la dirección donde se encuentran los iconos de acuerdo a la configuración
        /// </summary>
        public static string GetIconsFullPath()
        {
            string iconsFolder = Properties.Settings.Default.IconsFolder;

            return System.IO.Path.GetFullPath(iconsFolder);
        }

        /// <summary>
        /// Description: Retorna la dirección donde se encuentran los backgrounds de acuerdo a la configuración
        /// </summary>
        public static string GetBackgroundsFullPath()
        {
            string backgroundsFolder = Properties.Settings.Default.BackgroundsFolder;

            return System.IO.Path.GetFullPath(backgroundsFolder);
        }

        /// <summary>
        /// Description: Retorna la dirección donde se encuentran las imágenes de acuerdo a la configuración
        /// </summary>
        public static string GetImagesFullPath()
        {
            string imagesFolder = Properties.Settings.Default.ImagesFolder;

            return System.IO.Path.GetFullPath(imagesFolder);
        }

        public static bool ValidateTextFloat(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            if (regex.IsMatch(e.Text) && !(e.Text == "." && ((TextBox)sender).Text.Contains(e.Text)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
