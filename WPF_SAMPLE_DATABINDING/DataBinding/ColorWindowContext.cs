using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataBinding
{
    public class ColorWindowContext :ObservableObject
    {
        public List<ColorDescriptor> LotsOfColor { get; private set; }


        public ColorWindowContext()
        {
            LotsOfColor = new List<ColorDescriptor>()
            {
                new  ColorDescriptor(Colors.Red,"red")
                ,new ColorDescriptor(Colors.White,"white")
                ,new ColorDescriptor(Colors.Green,"green")
                ,new ColorDescriptor(Colors.Yellow,"yellow")
                ,new ColorDescriptor(Colors.Blue,"blue")
                ,new ColorDescriptor(Colors.Black,"black")
            };

            SelectDescriptor = this.LotsOfColor[0];
        }


        private ColorDescriptor _selectDescriptor;


        public ColorDescriptor SelectDescriptor
        {
            get
            {
                return _selectDescriptor;
            }
            set
            {
                _selectDescriptor = value;
                this.SetProperty(ref _selectDescriptor, value);
            }
        }


        public ObservableCollection<ColorDescriptor> FavoritesColors { get; } = new ObservableCollection<ColorDescriptor>();

        public void AddFavoritesColor()
        {

            foreach(var item in FavoritesColors)
            {
                if(item.color==_selectDescriptor.color && item.Name == _selectDescriptor.Name)
                {
                    return;
                }
            }

            FavoritesColors.Add(_selectDescriptor);
            this.NotifyPropertyChanged(nameof(FavoritesColors));
        }

        public void RemoveFavoritesColor(ColorDescriptor color)
        {
           var query = FavoritesColors.Where(i => i.color == color.color && i.Name == color.Name).ToList();

            for(int i = 0; i < query.Count(); i++)
            {
                FavoritesColors.Remove(query[i]);
                this.NotifyPropertyChanged(nameof(FavoritesColors));
            }
        }
    }
}
