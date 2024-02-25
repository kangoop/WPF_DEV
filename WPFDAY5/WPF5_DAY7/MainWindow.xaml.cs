using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF5_DAY7
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        //Observable 변수명이랑 view 의 xaml 이랑 변수명이 동일해야한다.
        private SampleData sample = new SampleData();

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }


        public ObservableCollection<Employee> employees { get { return sample.EmployeeList; } }
    }
}
