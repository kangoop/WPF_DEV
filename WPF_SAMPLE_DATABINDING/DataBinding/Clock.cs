using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DataBinding
{
    public class Clock : INotifyPropertyChanged
    {
        private DispatcherTimer _timer;

        //InotifyPropertyChanged 상속시 구현해야함 
        public event PropertyChangedEventHandler PropertyChanged;

        public string CurrentTime { 
            get 
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff");
            } 
        }

        public string CurrentTime_UTC
        {
            get
            {
                return DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss:fff");
            }
        }

        public Clock()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(500) };

            _timer.Tick += _timer_Tick;

            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            // Debug.WriteLine($"{nameof(CurrentTime_UTC)} : {CurrentTime_UTC}, {nameof(CurrentTime)} : {CurrentTime}");

            //속성 이름이 문자열이어야 하는 생성자
            //PropertyChangedEventArgs
            //ProertyChanged를 구독하고 있는 시스템 ( wpf )
            PropertyChanged(this,new PropertyChangedEventArgs(nameof(CurrentTime)));
            PropertyChanged(this, new PropertyChangedEventArgs(nameof(CurrentTime_UTC)));
        }
    }
}
