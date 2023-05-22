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
            

            //Задание 4

            double N = Convert.ToDouble(TbNumberA.Text);
            double z = (N + Math.Cos(N + 1)) / Math.Sin(N + 1);
            double c = Math.Abs((N + z) / 5 - (3 + z));
            TextBlockAnswer.Text = $"c = {c:N2}";

        }
    }
}
