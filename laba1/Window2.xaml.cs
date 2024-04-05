using laba1.dartbaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        PlatformsTableAdapter Platforms = new PlatformsTableAdapter();
        public Window2()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = Platforms.GetData();
            ComboFilter.ItemsSource = Platforms.GetData();
            ComboFilter.DisplayMemberPath = "ID_Platform";
        }

        private void DevelopersButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow DevelopersDS = new MainWindow();
            DevelopersDS.Show();
            Close();
        }

        private void GamesButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 GamesDS = new Window1();
            GamesDS.Show();
            Close();
        }

        private void PlatformsButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 PlatformsDS = new Window2();
            PlatformsDS.Show();
            Close();
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboFilter.SelectedItem != null)
            {
                var id = (int)(ComboFilter.SelectedItem as DataRowView).Row[0];
                MyDataGrid.ItemsSource = Platforms.FilterByID(id);
            }
        }

        private void ButtonFilter_Click(object sender, RoutedEventArgs e)
        {
            MyDataGrid.ItemsSource = Platforms.GetData();
        }
    }
}