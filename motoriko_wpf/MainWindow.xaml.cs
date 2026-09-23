using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace motoriko_wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTask1_Click(object sender, RoutedEventArgs e)
            => FrmMain.Navigate(new Pages.Task1());

        private void btnTask2_Click(object sender, RoutedEventArgs e)
            => FrmMain.Navigate(new Pages.Task2());

        private void btnTask3_Click(object sender, RoutedEventArgs e)
            => FrmMain.Navigate(new Pages.Task3());

        private void btnTask4_Click(object sender, RoutedEventArgs e)
            => FrmMain.Navigate(new Pages.Task4());

        private void btnTask5_Click(object sender, RoutedEventArgs e)
            => FrmMain.Navigate(new Pages.Task5());

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrmMain.CanGoBack)
                FrmMain.GoBack();
        }

        private void FrmMain_ContentRendered(object sender, System.EventArgs e)
        {

        }
    }
}