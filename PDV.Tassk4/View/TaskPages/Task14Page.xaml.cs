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
    /// <summary>
    /// Логика взаимодействия для Task14Page.xaml
    /// </summary>
    public partial class Task14Page : Page
    {
        public Task14Page()
        {
            InitializeComponent();
        }

        private void BtnTask14_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(TbX.Text);
                int N = Convert.ToInt32(TbN.Text);
                double a = X;
                if (X < 0)
                {
                    for (int i = 0; i <= N; i += 2)
                    {
                        a -= -1 * i - 1 * Math.Pow(X, i) / i;
                    }
                    MessageBox.Show($" Произведение = {a}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                if (X > 0)
                    MessageBox.Show($"Число X не должно быть положительным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                TbX.Text = string.Empty;
                TbN.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }
    }
}