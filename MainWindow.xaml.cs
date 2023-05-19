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

namespace _215_skvor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(TbNumberA.Text);
            double b = Convert.ToDouble(TbNumberB.Text);
            double sum = a + b;
            double diff = a - b;
            double prod = a * b;
            double quot = a * a / (b * b);

            string result = $"Сумма: {sum:N2}\nРазность: {diff:N2}\nПроизведение: {prod:N2}\nЧастное квадратов: {quot:N2}";

            TextBlockAnswer.Text = $"Ответ:\n{a:N2} + {b:N2} = {sum:N2}\n{a:N2} - {b:N2} = {diff:N2}\n{a:N2} * {b:N2} = {prod:N2}\n{a:N2}^2 / {b:N2}^2 = {quot:N2}\n\n{result}";



        }
    }
}
