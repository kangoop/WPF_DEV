using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPF4_3
{
    public class MLstackpanel :StackPanel
    {

        public static DependencyProperty IsBrownBkgrdProperty = DependencyProperty.Register("IsBrownBkgrd"
            , typeof(bool)
            , typeof(MLstackpanel)
            , new PropertyMetadata(false,OnIsBrownBkgrdChanged,CoerceIsBrownBkgrdChanged));


        


        public bool IsBrownBkgrnd
        {
            get { return (bool)GetValue(IsBrownBkgrdProperty); }

            set { SetValue(IsBrownBkgrdProperty, value); }
        }

        private static object CoerceIsBrownBkgrdChanged(DependencyObject d, object value)
        {
            MLstackpanel m = d as MLstackpanel;

            if (m.IsBrownBkgrnd == false)
            {
                MessageBox.Show("The IsBrownBkgrd dependency property is being changed to true");
                return true;
            }
            else
            {
                MessageBox.Show("The IsBrownBkgrd dependency property is being changed to false");
                return false;
            }

        }

        private static void OnIsBrownBkgrdChanged(DependencyObject source,DependencyPropertyChangedEventArgs e)
        {
            MLstackpanel msp = source as MLstackpanel;

            if (msp.IsBrownBkgrnd == true)
            {
                msp.Background = System.Windows.Media.Brushes.BurlyWood;
            }
            else
            {
                msp.Background = System.Windows.Media.Brushes.DarkGray;
            }
        }
    }
}
