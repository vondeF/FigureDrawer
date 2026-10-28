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
    public class RectangleFigure : Figure
    {
        public override string DisplayName => "Прямоугольник";
        public override FigureSettings CreateSettings() => new RectangleSettings();
        public override UIElement Draw(FigureSettings settings)
        {
            var s = (RectangleSettings)settings;
            return new Rectangle
            {
                Width = s.Width,
                Height = s.Height,
                Stroke = new SolidColorBrush(s.Color),
                StrokeThickness = s.Thickness
            };
        }
    }
}
