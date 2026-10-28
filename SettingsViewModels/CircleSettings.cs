using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FigureDrawer.SettingsViewModels
{
    public class CircleSettings : FigureSettings
    {
        private double _radius = 50;
        public double Radius
        {
            get => _radius;
            set { _radius = value; OnPropertyChanged(); }
        }
    }
}
