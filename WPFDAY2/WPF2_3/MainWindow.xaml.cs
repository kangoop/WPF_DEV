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

namespace WPF2_3
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Selected Option1";
        }

        private void rb1_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Selected Option2";
        }

        private void rb2_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private void rb3_Unchecked(object sender, RoutedEventArgs e)
        {
            label.Content = "Selected Option3";
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Selected Option4";
        }

        private void rb4_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
