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

            Manager4.MainFrame = MainFrame;
            MainFrame.Navigate(new Task1Page());
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task2Page());
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task1Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task3Page());
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Task5Page());
        }
    }
}
