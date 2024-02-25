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
using System.Windows.Shapes;

namespace WPF4_3
{
    /// <summary>
    /// NEWWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NEWWindow : Window
    {
        public NEWWindow()
        {
            InitializeComponent();
        }

        private void chkbkgcolor_Click(object sender, RoutedEventArgs e)
        {
            if (chkbkgcolor.IsChecked.Value == true)
            {
                mlstack.IsBrownBkgrnd = true;
            }
            else
            {
                mlstack.IsBrownBkgrnd = false;
            }
        }
    }
}
