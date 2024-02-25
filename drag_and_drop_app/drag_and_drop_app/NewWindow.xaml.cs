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

namespace drag_and_drop_app
{
    /// <summary>
    /// NewWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow(RadioButton radio )
        {
            InitializeComponent();


            this.MouseMove += NewWindow_MouseMove;
            this.PreviewMouseLeftButtonUp += NewWindow_PreviewMouseLeftButtonUp;

            switch(radio.Content)
            {
                case "TEST1":
                    this.ellipse.Fill = new SolidColorBrush(Colors.Red);
                    break;
                case "TEST2":
                    this.ellipse.Fill = new SolidColorBrush(Colors.Blue);
                    break;
                case "TEST3":
                    this.ellipse.Fill = new SolidColorBrush(Colors.Green);
                    break;
            }
        }

        private void NewWindow_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Opacity = 1;
        }

        private void NewWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.Opacity < 1)
            {

                System.Windows.Point position = e.GetPosition(this);
                this.Left = position.X;
                this.Top = position.Y;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
