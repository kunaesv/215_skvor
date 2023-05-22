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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            //Дополнительное задание 1

            int A1 = Convert.ToInt32(TbNumberA.Text);
            int B1 = Convert.ToInt32(TbNumberB.Text);
            int C1 = Convert.ToInt32(TbNumberC.Text);
            int A2 = Convert.ToInt32(TbNumberD.Text);
            int B2 = Convert.ToInt32(TbNumberF.Text);
            int C2 = Convert.ToInt32(TbNumberG.Text);

            double D = A1 * B2 - A2 * B1;
            double x = (C1 * B2 - C2 * B1) / D;
            double y = (A1 * C2 - A2 * C1) / D;

            TextBlockX.Text = $"x = {x}";
            TextBlockY.Text = $"y = {y}";
        }
    }
}
