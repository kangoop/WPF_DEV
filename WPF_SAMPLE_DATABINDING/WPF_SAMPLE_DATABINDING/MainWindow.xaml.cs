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

namespace WPF_SAMPLE_DATABINDING
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        private WindowDataContext _context => (WindowDataContext)DataContext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSubmitBtnClick(object sender, RoutedEventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(_context.UserName))
            {
                return;
            }

            _context.IsNameVisiable = false;

            //MessageBox.Show($"Hello {_context.UserName}!");
        }

        private void btn_click_colorchange(object sender, RoutedEventArgs e)
        {
            colorwpf wpf = new colorwpf();
            var result = wpf.ShowDialog();


        }
    }
}
