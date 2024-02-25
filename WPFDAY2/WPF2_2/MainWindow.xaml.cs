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

namespace WPF2_2
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

        private void cboBox_Checked(object sender, RoutedEventArgs e)
        {
            label.Content = "Extra Chocolate selected";
        }

        private void cboBox_Unchecked(object sender, RoutedEventArgs e)
        {
            label.Content = "   ";
        }

        private void cboBoxSugar_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cboBoxSugar_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
