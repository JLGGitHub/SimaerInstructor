using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanInstructor.Classes
{
    /// <summary>
    /// Description: Enumerador para indicar el tipo de interfaz
    /// </summary>
    public enum WindowsType
    {
        MainWindow,
        None
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
    }
}
