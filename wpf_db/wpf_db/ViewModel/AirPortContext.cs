using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_db.ViewModel
{
    public class AirPortContext : INotifyPropertyChanged
    {
        public AirPortContext()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
