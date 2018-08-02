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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaravanInstructor.Views.UserControls
{
    /// <summary>
    /// Interaction logic for ListFailsProceduresType1.xaml
    /// </summary>
    public partial class ListFailsProceduresType1 : UserControl
    {
        public ObservableCollection<CheckBoxItem> SelectFailsProcedures { get; set; }

        public ListFailsProceduresType1()
        {
            InitializeComponent();

            this.DataContext = this;

            SelectFailsProcedures = new ObservableCollection<CheckBoxItem>
            {
                new CheckBoxItem { IsChecked=false, Name="Item 1"},
                new CheckBoxItem { IsChecked=false, Name="Item 2"},
                new CheckBoxItem { IsChecked=false, Name="Item 3"},
                new CheckBoxItem { IsChecked=false, Name="Item 4"},
                new CheckBoxItem { IsChecked=false, Name="Item 5"},
                new CheckBoxItem { IsChecked=false, Name="Item 6"},
            };
        }

        private void _failProcedures_lis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void _checkBoxItem_chb_Click(object sender, RoutedEventArgs e)
        {
            var cb = sender as CheckBox;
            var item = cb.DataContext;
            _failProcedures_lis.SelectedItem = item;
        }
    }

    public class CheckBoxItem
    {
        public bool IsChecked { get; set; }
        public string Name { get; set; }
    }
}