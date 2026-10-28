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
    public class TriangleFigure : Figure
    {
        public override string DisplayName => "Треугольник";
        public override FigureSettings CreateSettings() => new TriangleSettings();
        public override UIElement Draw(FigureSettings settings)
        {
            var s = (TriangleSettings)settings;
            var triangle = new Polygon
            {
                Points = new PointCollection
                {
                    new Point(s.BaseWidth / 2, 0),        // вершина
                    new Point(s.BaseWidth,   s.Height),   // правый нижний
                    new Point(0,             s.Height)    // левый нижний
                },
                Stroke = new SolidColorBrush(s.Color),
                StrokeThickness = s.Thickness,
                Stretch = Stretch.None
            };
            return triangle;
        }
    }
}
