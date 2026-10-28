using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawer.SettingsViewModels
{
    public class RectangleSettings : FigureSettings
    {
        private double _width = 50;
        public double Width
        {
            get => _width;
            set { _width = value; OnPropertyChanged(); }
        }

        private double _height = 50;
        public double Height
        {
            get => _height;
            set { _height = value; OnPropertyChanged(); }
        }
    }
}
