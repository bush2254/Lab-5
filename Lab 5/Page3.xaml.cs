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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
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
            if (double.TryParse(TbNumber.Text, out double pricePerKg))
            {

                TbNumber.Text = "";


                for (int kg = 1; kg <= 10; kg++)
                {
                    double totalCost = pricePerKg * kg;
                    TextBlockAnswer.Text += $"{kg} кг: {totalCost} рублей\n";
                }
            }
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
