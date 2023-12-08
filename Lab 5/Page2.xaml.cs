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

namespace Lab_5
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(ListBoxData.Items[0]); int n1 = Convert.ToInt32(ListBoxData.Items[1]);
            int s = 0;
            for (int i = n; i <= n1; i++)
            {
                if (i % 2 == 1)
                {
                    s += 1;
                }
            }
            if (s > 0)
            {
                MessageBox.Show($"ответ:\n {s}");
            }
            else
            {
                MessageBox.Show($"ответ:\n No");
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
