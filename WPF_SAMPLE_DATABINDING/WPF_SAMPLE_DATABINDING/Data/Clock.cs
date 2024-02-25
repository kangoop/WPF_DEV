using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace WPF_SAMPLE_DATABINDING
{
    public class Clock : INotifyPropertyChanged
    {

        private DispatcherTimer _timer;

        public event PropertyChangedEventHandler PropertyChanged;

       
        public string CurrentTime =>
            
            
            DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public Clock()
        {
           
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            
            _timer.Tick += _timer_Tick;

            //PropertyChanged += PropertyChangedFunc; 주석 처리 후 
            //_timer.Tick += (sender, o) => PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));

            _timer.Start();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            PropertyChanged(this,new PropertyChangedEventArgs(nameof(CurrentTime)));
        }



    }
}
