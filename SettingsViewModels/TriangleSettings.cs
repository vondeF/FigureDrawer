using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDrawer.SettingsViewModels
{
    public class TriangleSettings : FigureSettings
    {
        private double _baseWidth = 120;
        private double _height = 100;

        //Длина основания треугольника
        public double BaseWidth
        {
            get => _baseWidth;
            set { _baseWidth = value; OnPropertyChanged(); }
        }

        //Высота от основания до вершины
        public double Height
        {
            get => _height;
            set { _height = value; OnPropertyChanged(); }
        }
    }
}
