using FigureDrawer.SettingsViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace FigureDrawer.Figures
{
    public class CircleFigure : Figure
    {
        public override string DisplayName => "Круг";
        public override FigureSettings CreateSettings() => new CircleSettings();
        public override UIElement Draw(FigureSettings settings)
        {
            var s = (CircleSettings)settings;
            return new Ellipse
            {
                Width = s.Radius * 2,
                Height = s.Radius * 2,
                Stroke = new SolidColorBrush(s.Color),
                StrokeThickness = s.Thickness
            };
        }
    }
}
