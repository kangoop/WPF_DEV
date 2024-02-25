using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_SAMPLE_DATABINDING
{
    //창 수준의 데이터 바인딩 클래스 
    public class WindowDataContext :INotifyPropertyChanged
    {
        private string _UserName;

        private bool _isNameVisiable = true;

        public bool IsNameVisiable
        {
            get { return _isNameVisiable; }
            set
            {
                if (value != _isNameVisiable)
                {
                    _isNameVisiable = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(IsNameVisiable)));
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(GreetingVisibility)));
                }
            }
        }

        public Visibility GreetingVisibility => IsNameVisiable ? Visibility.Collapsed : Visibility.Visible;

        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
                RaisePropertyChanged(nameof(IsSubmitAllowed));
            }
        }

        private void RaisePropertyChanged(string v)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this,new PropertyChangedEventArgs(v));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public  bool IsSubmitAllowed
        {
            get
            {
                return !string.IsNullOrWhiteSpace(UserName);
            }
        }

        public WindowDataContext()
        {

        }

        
    }
}
