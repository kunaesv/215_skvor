using System;
using System.Collections.Generic;
using System.Text;
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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            //Задание 1

            //double a = Convert.ToDouble(TbNumberA.Text);
            //double b = Convert.ToDouble(TbNumberB.Text);
            //double sum = a + b;
            //double diff = a - b;
            //double prod = a * b;
            //double quot = a * a / (b * b);

            //string result = $"Сумма: {sum:N2}\nРазность: {diff:N2}\nПроизведение: {prod:N2}\nЧастное квадратов: {quot:N2}";

            //TextBlockAnswer.Text = $"Ответ:\n{a:N2} + {b:N2} = {sum:N2}\n{a:N2} - {b:N2} = {diff:N2}\n{a:N2} * {b:N2} = {prod:N2}\n{a:N2}^2 / {b:N2}^2 = {quot:N2}\n\n{result}";

            //Задание 2

            //int A = Convert.ToInt32(TbNumberA.Text);
            //int B = Convert.ToInt32(TbNumberB.Text);

            //int temp = A;
            //A = B;
            //B = temp;

            //TextBlockAnswer.Text = $"Новые значения:\nA = {A}\nB = {B}";

            //Задание 3

            //double TF = Convert.ToDouble(TbNumberA.Text);
            //double TC = (TF - 32) * 5 / 9;

            //TextBlockAnswer.Text = $"Температура по Цельсию: {TC:N2}";

            //Задание 4

            double N = Convert.ToDouble(TbNumberA.Text);
            double z = (N + Math.Cos(N + 1)) / Math.Sin(N + 1);
            double c = Math.Abs((N + z) / 5 - (3 + z));
            TextBlockAnswer.Text = $"c = {c:N2}";

        }
    }
}
