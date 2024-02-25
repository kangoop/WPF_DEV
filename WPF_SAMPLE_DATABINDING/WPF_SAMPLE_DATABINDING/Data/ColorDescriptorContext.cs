



using Microsoft.VisualStudio.PlatformUI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WPF_SAMPLE_DATABINDING
{
    public class ColorDescriptorContext : ObservableObject
    {

        private ColorDescriptor _selectColor;

        public ColorDescriptor selectColor
        {
            get { return _selectColor; }

            set
            {
                this.SetProperty(ref _selectColor, value);

            }
        }

        private ColorDescriptor _selected_favoriteColor;    //SelectedFavoriteColor가 변경되면 UI에서 이 속성을 쿼리하고 그에 따라 작업

        public ColorDescriptor SelectedFavoriteColor
        {
            get => _selected_favoriteColor;
            set
            {
                this.SetProperty(ref _selected_favoriteColor, value);
                this.NotifyPropertyChanged(nameof(IsRemoveFavoriteEnabled));
            }
        }

        public bool IsRemoveFavoriteEnabled => SelectedFavoriteColor != null;

        




        public List<ColorDescriptor> list_colors { get; set; }

        public ObservableCollection<ColorDescriptor> favorite_colors { get; } = new ObservableCollection<ColorDescriptor>(); //ObservableObject 의 컬렉션을 이용해야 UI 에 업데이트 된 내용을 알려준다.

        


        public ColorDescriptorContext()
        {
            list_colors = new List<ColorDescriptor>()
            {
                new  ColorDescriptor(Colors.Red,"red")
                ,new ColorDescriptor(Colors.White,"white")
                ,new ColorDescriptor(Colors.Green,"green")
                ,new ColorDescriptor(Colors.Yellow,"yellow")
                ,new ColorDescriptor(Colors.Blue,"blue")
                ,new ColorDescriptor(Colors.Black,"black")
            };

            selectColor = list_colors.First();
        }


        public void AddSelectedColorFavorites()
        {
            if (selectColor == null)
            {
                return;
            }

            favorite_colors.Add(selectColor);
        }

        public void RemoveSelectedColorFavorites()
        {
            if (SelectedFavoriteColor == null)
            {
                return;
            }

            favorite_colors.Remove(SelectedFavoriteColor);
        }

    }
}
