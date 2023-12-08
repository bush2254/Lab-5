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
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
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
           double X = Convert.ToDouble(ListBoxData.Items[0]);
           int N = Convert.ToInt32(ListBoxData.Items[1]);
            double result = 0.0;

            for (int i = 1; i <= N; i++)
            {
                result += Math.Pow(-1, i - 1) * Math.Pow(X, i) / i;
            }

            TextBlockAnswer.Text = $"ln(1 +  {N}{X}) ≈ {result}";
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0); 
        }
    }
}
