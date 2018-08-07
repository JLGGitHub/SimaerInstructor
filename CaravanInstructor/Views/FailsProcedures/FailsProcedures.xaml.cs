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
using CaravanInstructor.Views.UserControls;
using Telerik.Windows.Controls;

namespace CaravanInstructor.Views.FailsProcedures
{
    /// <summary>
    /// Interaction logic for FailsProcedures.xaml
    /// </summary>
    public partial class FailsProcedures : Window
    {
        #region Variables
        private MainWindow _parent_win;
        private SystemLogic systemLogic;
        private ProcedureLogic procedureLogic;
        private List<system> Systems;
        private List<procedure_type> ProcedureTypes;

        public List<SystemsCaravan> SystemsCaravan { get; set; }

        private ListFailsProceduresType1 _listFailsProceduresType1_use;
        private ListFailsProceduresType2 _listFailsProceduresType2_use;
        private ListFailsProceduresType3 _listFailsProceduresType3_use;
        private ListFailsProceduresType4 _listFailsProceduresType4_use;
        #endregion

        #region Getters y setters
        public MainWindow Parent_win
        {
            get
            {
                return this._parent_win;
            }
            set
            {
                this._parent_win = value;
            }
        }
        #endregion

        #region Singleton
        private static FailsProcedures instance = null;

        public static FailsProcedures GetInstance()
        {
            if (instance == null)
                instance = new FailsProcedures();
            return instance;
        }
        #endregion

        public FailsProcedures()
        {
            InitializeComponent();

            systemLogic = new SystemLogic();
            procedureLogic = new ProcedureLogic();

            SetInitConfigWindow();
            GetData();
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

            _listFailsProceduresType1_use = new ListFailsProceduresType1();
            _listFailsProceduresType2_use = new ListFailsProceduresType2();
            _listFailsProceduresType3_use = new ListFailsProceduresType3();
            _listFailsProceduresType4_use = new ListFailsProceduresType4();
        }

        /// <summary>
        /// Description: Obtiene los datos de la base de datos
        /// </summary>
        private void GetData()
        {
            DataContext = this;

            Systems = systemLogic.ReadSystems();
            ProcedureTypes = procedureLogic.ReadProceduresTypes();

            SystemsCaravan = new List<SystemsCaravan>();
            SystemsCaravan systemCaravan;
            ProceduresType proceduresType;

            foreach (system system in Systems)
            {
                systemCaravan = new SystemsCaravan(system);
                foreach (procedure_type proceduretype in ProcedureTypes)
                {
                    proceduresType = new ProceduresType(proceduretype);
                    List<procedure> listProcedures = procedureLogic.ReadProceduresBySystemProcType(system, proceduretype);
                    foreach (var procedure in listProcedures)
                    {
                        proceduresType.Procedures.Add(new Procedures(procedure));
                    }

                    if (proceduresType.Procedures.Count > 0)
                    {
                        systemCaravan.ProceduresType.Add(proceduresType);
                    }
                }
                SystemsCaravan.Add(systemCaravan);
            }
        }

        /// <summary>
        /// Description: Cuando se cierra la ventana muestra al padre y esconde la ventana
        /// </summary>
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                _parent_win.Show();
                e.Cancel = true;
                this.Hide();
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Description: Muestra al padre y cierra la ventana
        /// </summary>
        public void BackButton()
        {
            _parent_win.Show();
            this.Hide();
        }

        /// <summary>
        /// Description: Muestra cada uno de los procedimiento de la categoría seleccionada
        /// </summary>
        private void _radTreeViewSystems_rtv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ProceduresType proceduresType = _radTreeViewSystems_rtv.SelectedItem as ProceduresType;
            
            if (proceduresType != null)
            {
                RadTreeView treeView = sender as RadTreeView;
                RadTreeViewItem item = treeView.ContainerFromItemRecursive(treeView.SelectedItem);
                RadTreeViewItem parentItem = item.ParentItem;
                SystemsCaravan systemsCaravan = parentItem.DataContext as SystemsCaravan;

                if(systemsCaravan != null)
                {
                    if ((systemsCaravan.System.system_id == (int) EnumSystemsType.Fuel) && (proceduresType.ProcedureType.procedure_type_id == (int)EnumProceduresType.Failure))
                    {
                        _listFailsProcedures_cco.Content = _listFailsProceduresType2_use;
                        _listFailsProceduresType2_use.UpdateData(item.Index, systemsCaravan);
                    }
                    else
                    {
                        if ((systemsCaravan.System.system_id == (int)EnumSystemsType.Miscellaneus) && (proceduresType.ProcedureType.procedure_type_id == (int)EnumProceduresType.Failure))
                        {
                            _listFailsProcedures_cco.Content = _listFailsProceduresType3_use;
                            _listFailsProceduresType3_use.UpdateData(item.Index, systemsCaravan);
                        }
                        else
                        {
                            if ((systemsCaravan.System.system_id == (int)EnumSystemsType.Electrical) && (proceduresType.ProcedureType.procedure_type_id == (int)EnumProceduresType.Failure))
                            {
                                _listFailsProcedures_cco.Content = _listFailsProceduresType4_use;
                                _listFailsProceduresType4_use.UpdateData(item.Index, systemsCaravan);
                            }
                            else
                            {
                                _listFailsProcedures_cco.Content = _listFailsProceduresType1_use;
                                _listFailsProceduresType1_use.UpdateData(item.Index, systemsCaravan);
                            }
                        }
                    }
                }
            }
        }
    }
}
