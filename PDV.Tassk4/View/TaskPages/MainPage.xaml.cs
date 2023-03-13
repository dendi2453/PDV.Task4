using PDV.Tassk4.Core;
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

namespace PDV.Tassk4.View.TaskPages
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task1Page());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task2Page());
        }


        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task3Page());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task4Page());
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task5Page());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task6Page());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task7Page());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task8Page());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task9Page());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task10Page());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task11Page());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task12Page());
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task13Page());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task14Page());
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new Task8Page());
        }
    }
}
