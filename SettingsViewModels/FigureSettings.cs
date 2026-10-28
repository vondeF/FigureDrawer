using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FigureDrawer.SettingsViewModels
{
    public abstract class FigureSettings : INotifyPropertyChanged
    {
        // Цвет обводки
        protected Color _color = Colors.Black;
        public Color Color
        {
            get => _color;
            set { _color = value; OnPropertyChanged(); }
        }

        // Толщина обводки
        protected double _thickness = 2;
        public double Thickness
        {
            get => _thickness;
            set { _thickness = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
