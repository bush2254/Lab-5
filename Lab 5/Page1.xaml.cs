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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(ListBoxData.Items[0]); int s = 0;
            for (int i = 1; i <= n; i++)
            {
                int m = Convert.ToInt32(ListBoxData.Items[i]); 
                if (m % 3 == 0 && m % 10 == 4)
                {
                    s += m;
                }
            }
            if (s > 0)
            {
                TextBlockAnswer.Text = $"ответ:\n{s}";
            }
            else
            {
                TextBlockAnswer.Text = $"ответ:\n чисел оканчивающихся на 4 и кратных 3 нету";
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
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
    }
}
