using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace drag_and_drop_app
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

       

        public MainWindow()
        {
            InitializeComponent();

            this.PreviewMouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
            this.MouseMove += MainWindow_MouseMove;
            this.PreviewMouseLeftButtonUp += MainWindow_MouseLeftButtonUp;

        
        }


        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnGiveFeedback(e);

            if (e.Effects.HasFlag(DragDropEffects.None))
            {
                Mouse.SetCursor(Cursors.Hand);
            }

            e.Handled = true;
        }

        private void MainWindow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($" {nameof(MainWindow_MouseLeftButtonUp)} {DateTime.Now.ToString("yyyyMMddHHmmss:fff")} X :{e.MouseDevice.GetPosition(null).X} Y : {e.MouseDevice.GetPosition(null).Y}");

            _IsMouseDown = false;

           
        }


        private NewWindow _showingWindow = null;

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine($"{DateTime.Now.ToString("yyyyMMddHHmmss:fff")} X :{e.MouseDevice.GetPosition(null).X} Y : {e.MouseDevice.GetPosition(null).Y} {e.MouseDevice.LeftButton.ToString()}");

            MouseMoveCheck();

            void MouseMoveCheck()
            {
               
                var hor = Math.Abs(e.MouseDevice.GetPosition(null).X - _IsMouseDown_pt.X);
                var ver = Math.Abs(e.MouseDevice.GetPosition(null).Y - _IsMouseDown_pt.Y);

                var diff_value = Math.Sqrt(ver * ver + hor * hor);

                Debug.WriteLine(Math.Sqrt(ver * ver + hor * hor));

                if(diff_value>10 && _IsMouseDown)
                {
                    if (e.Source is RadioButton)
                    {
                        var radio = e.Source as RadioButton;
                        Debug.WriteLine(radio.Content);
                        Debug.WriteLine("DragOn");
                        DragDrop.DoDragDrop(radio, radio.Content.ToString(), DragDropEffects.None);
                        //_showingWindow = new NewWindow(radio);
                        //_IsMouseDown = false;
                        //_showingWindow.Show();
                        
                    }
                }
            }
        }





        private bool _IsMouseDown = false;
        private Point _IsMouseDown_pt=new Point();
        private void MainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine($" {nameof(MainWindow_MouseLeftButtonDown)} {DateTime.Now.ToString("yyyyMMddHHmmss:fff")} X :{e.MouseDevice.GetPosition(null).X} Y : {e.MouseDevice.GetPosition(null).Y} State : {e.MouseDevice.LeftButton.ToString()}");


            if (tab.IsMouseOver)
            {
                Debug.WriteLine("YES");

                foreach(UIElement element in tab.Children)
                {
                    if (element.IsMouseOver)
                    {
                        Debug.WriteLine("Radio YES");

                        var radio = element as RadioButton;

                        element.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));

                        _IsMouseDown = true;
                        _IsMouseDown_pt = new Point(e.MouseDevice.GetPosition(null).X, e.MouseDevice.GetPosition(null).Y);

                        element.RaiseEvent(new MouseEventArgs(Mouse.PrimaryDevice, 0)
                        {
                            RoutedEvent = Mouse.MouseMoveEvent
                            ,
                            Source = element
                        });

                        e.Handled = true;
                    }
                }
            }


            
            //RaiseEvent(new MouseButtonEventArgs(Mouse.PrimaryDevice, 0, MouseButton.Left)
            //{
            //    RoutedEvent = Mouse.MouseUpEvent,
            //    Source = this
            //});
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            var radio = sender as RadioButton;
            radio.IsChecked = true;
            Debug.WriteLine(radio.Content);
        }
    }
}
