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
    /// Логика взаимодействия для Task11Page.xaml
    /// </summary>
    public partial class Task11Page : Page
    {
        public Task11Page()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double X = Convert.ToDouble(TbX.Text);
                int N = Convert.ToInt32(TbN.Text);
                double a = 1;
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    {
                        a += Math.Pow(X, i) / i;
                    }
                    MessageBox.Show($" Произведение = {a}", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }
                if (N < 0)
                    MessageBox.Show($"Число N не может быть отрицательным", "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);

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
