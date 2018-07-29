﻿using System;
using System.Collections.Generic;
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
using CaravanInstructor.Classes;
using CaravanInstructor.Classes.Pilot;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;

namespace CaravanInstructor.Views.Select
{
    /// <summary>
    /// Lógica de interacción para SelectInstructor.xaml
    /// </summary>
    public partial class SelectInstructor : Window
    {
        private MainWindow _parent_win;

        public SelectInstructor(MainWindow i_parent)
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
            _iconWindow_img.Source = new BitmapImage(new Uri(iconsFullPath + "pilot.png"));

            _bottomNavigation_use.SetCollapsedButtons(2, 2, 2, 2, 2, 2, 2, 2, 0);
            _bottomNavigation_use.ParentWindow_wty = WindowsType.Scenario;
        }

        /// <summary>
        /// Description: Cada vez que cambie el tamaño de la pantalla siempre la configura a FullHD
        /// </summary>
        private void ChangedEvent(object sender, SizeChangedEventArgs e)
        {
            this.Height = 1080.0;
            this.Width = 1920.0;
        }

        #region Eventos botones
        /// <summary>
        /// Description: Valida la selección de un instructor
        /// </summary>
        private void _nextButton_btn_Click(object sender, RoutedEventArgs e)
        {
            Pilot pilotSelected = _pilotGridView_rgv.SelectedItem as Pilot;
            
            if (pilotSelected != null)
            {
                _parent_win.Show();
                this.Close();
            }
            else
            {
                RadWindow.Alert(new DialogParameters
                {
                    Header = "Alert",
                    Content = "Select instructor and press next",
                    OkButtonContent = "Ok",
                    Owner = this
                });
            }
        }
        #endregion

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _parent_win.Show();
        }

        private void _newPilotButton_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void PART_SearchAsYouTypeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RadWatermarkTextBox waterMarkTextBox = sender as RadWatermarkTextBox;

            if(waterMarkTextBox.Text == "")
            {
                waterMarkTextBox.Foreground = Brushes.LightGray;
            }
            else
            {
                waterMarkTextBox.Foreground = Brushes.Black;
            }
        }
    }

    public class ButtonGridViewColumn : Telerik.Windows.Controls.GridViewColumn
    {
        public override FrameworkElement CreateCellElement(GridViewCell cell, object dataItem)
        {
            Button button = cell.Content as Button;
            if (button == null)
            {
                button = new Button();
                button.BorderThickness = new Thickness(0);
                button.Background = null;
                button.Content = "DEL/EDIT";

                button.Click += Button_Click;

            }

            return button;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;
                if (btn.Tag != null)
                {
                }
            }
        }
    }
}
