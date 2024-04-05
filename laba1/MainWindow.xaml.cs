using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using laba1.dartbaseDataSetTableAdapters;

namespace laba1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DevelopersTableAdapter Developers = new DevelopersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = Developers.GetData();
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

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            MyDataGrid.ItemsSource = Developers.SearchByOwner(SearchTxt.Text);
        }
    }
}
