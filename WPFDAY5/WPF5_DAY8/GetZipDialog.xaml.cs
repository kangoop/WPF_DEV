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

namespace WPF5_DAY8
{
    /// <summary>
    /// GetZipWPF.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GetZipDialog : Window
    {
        public string Zip { get; set; }

        public GetZipDialog()
        {
            InitializeComponent();
        }
        private void btnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            Zip = txtAnswer.Text;
        }
    }
}
