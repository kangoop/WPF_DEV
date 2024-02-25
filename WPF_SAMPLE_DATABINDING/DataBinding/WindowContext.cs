using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DataBinding
{
    public class WindowContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private string _username;

        public string UserName {
            get
            {
                return _username;
            }
            set
            {
                if(UserName != value)
                {
                    _username = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(UserName));
                }
            }
        }

        private bool _isNameNeeded = true;

        public bool IsNameNeeded
        {
            get { return _isNameNeeded; }
            set
            {
                if(value != _isNameNeeded)
                {
                    _isNameNeeded = value;
                    PropertyChanged(this,new PropertyChangedEventArgs(nameof(IsNameNeeded)));
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(HelloMsgVisibility)));
                    // INotifyPropertyChanged 인터페이스의 표준 패턴
                    // 값이 변경되었는지 여부를 확인합니다.
                    // 변경된 경우 새 값을 설정합니다.
                    // UI에 알립니다.
                }
            }
        }


        public Visibility HelloMsgVisibility
        {
            get
            {
                if (IsNameNeeded)
                {
                    return Visibility.Collapsed; 
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }

        public WindowContext()
        {
            
        }
    }
}
