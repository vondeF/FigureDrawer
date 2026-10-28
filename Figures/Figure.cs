using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using FigureDrawer.SettingsViewModels;

namespace FigureDrawer.Figures
{
    public abstract class Figure
    {
        public abstract string DisplayName { get; }

        // Создает ViewModel с настройками фигуры
        public abstract FigureSettings CreateSettings();

        // Создает UIElement на основе переданных настроек
        public abstract UIElement Draw(FigureSettings settings);
    }
}
