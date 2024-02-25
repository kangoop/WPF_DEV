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

namespace DataBinding
{
    /// <summary>
    /// ColorWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ColorWindow : Window
    {

        private ColorWindowContext _context; 

        public ColorWindow()
        {
            InitializeComponent();

            _context = (ColorWindowContext)DataContext;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
           
        }

        private void btn_favorites_click(object sender, RoutedEventArgs e)
        {
            this._context.AddFavoritesColor();
        }

        private void btn_remove_click(object sender, RoutedEventArgs e)
        {
           var btn = sender as Button;
           var parent = btn.Parent as StackPanel;

            foreach(var child in parent.Children)
            {
                if(child is Rectangle)
                {
                    var rect = child as Rectangle;
                    var data = rect.DataContext as ColorDescriptor;

                    this._context.RemoveFavoritesColor(data);
                }
            }
        }
    }
}
