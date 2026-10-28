using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FigureDrawer.Figures;
using FigureDrawer.SettingsViewModels;

namespace FigureDrawer
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        // Доступные фигуры для отрисовки
        public ObservableCollection<Figure> AvailableFigures { get; }


        // Выбранная фигура
        private Figure? _selectedFigure;
        public Figure? SelectedFigure
        {
            get => _selectedFigure;
            set
            {
                if (_selectedFigure == value) return;
                _selectedFigure = value;
                OnPropertyChanged();

                // Создаём настройки
                CurrentSettings = value?.CreateSettings();
                DrawCommand.RaiseCanExecuteChanged();
            }
        }


        // Настройки фигуры
        private FigureSettings? _currentSettings;
        public FigureSettings? CurrentSettings
        {
            get => _currentSettings;
            private set { _currentSettings = value; OnPropertyChanged(); }
        }


        // UI элементы
        public ObservableCollection<UIElement> CanvasItems { get; } = new();


        // Высота холста
        private double _canvasWidth;
        public double CanvasWidth
        {
            get => _canvasWidth;
            set { if (_canvasWidth == value) return; _canvasWidth = value; OnPropertyChanged(); }
        }


        // Ширина холста
        private double _canvasHeight;
        public double CanvasHeight
        {
            get => _canvasHeight;
            set { if (_canvasHeight == value) return; _canvasHeight = value; OnPropertyChanged(); }
        }


        public RelayCommand DrawCommand { get; }


        public MainWindowViewModel()
        {
            AvailableFigures = new ObservableCollection<Figure>()
            {
                new CircleFigure(),
                new RectangleFigure(),
                new TriangleFigure(),
            };

            DrawCommand = new RelayCommand(OnDraw, () => SelectedFigure != null);
        }

        /// <summary>
        /// Выполняем отрисовку фигуры
        /// </summary>
        private void OnDraw()
        {
            var shape = SelectedFigure!.Draw(CurrentSettings!);

            shape.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            var size = shape.DesiredSize;

            // Ставим так, чтобы центр фигуры попал в центр холста
            Canvas.SetLeft(shape, (CanvasWidth - size.Width) / 2);
            Canvas.SetTop(shape, (CanvasHeight - size.Height) / 2);

            CanvasItems.Clear();
            CanvasItems.Add(shape);
        }

        public void OnCanvasSizeChanged(double width, double height)
        {
            CanvasWidth = width;
            CanvasHeight = height;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
