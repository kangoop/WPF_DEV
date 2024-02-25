using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataBinding
{
    public class ColorDescriptor : ObservableObject
    {
        public ColorDescriptor(Color color , string name)
        {
            this.color = color;
            this.Name = name;
        }

        public Color color{ get; private set; }

        public string Name { get; private set; }


        public override string ToString()
        {
            return $"{Name} (#{color.R:X2},{color.G:X2},{color.B:X2})";
        }
    }
}
