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
        SelectInstructor,
        SelectStudent,
        Scenario,
        FailProcedures,
        Setting,
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
    }
}
