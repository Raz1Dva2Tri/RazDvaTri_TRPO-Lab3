using RazDvaTri_TRPO_Lab3.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RazDvaTri_TRPO_Lab3.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateTriangle()
        {
            if (double.TryParse(SideABox.Text, out double a) && double.TryParse(SideBBox.Text, out double b) &&
                double.TryParse(SideCBox.Text, out double c))
            {
                Triangle triangleArea = new(a, b, c);
                

                double hA = 2 * triangleArea.S / a;
                AreaLabel.Content = $"Площадь треугольника = {triangleArea.S}";
                double xB = a * b / (b + c);
                double yB = hA;

                double xC = a * c / (b + c);
                double yC = 0;

                PathFigure triangleFigure = new PathFigure { StartPoint = new Point(0, 0) };
                triangleFigure.Segments.Add(new LineSegment(new Point(xB, yB), true));
                triangleFigure.Segments.Add(new LineSegment(new Point(xC, yC), true));

                PathGeometry geometry = new PathGeometry();
                geometry.Figures.Add(triangleFigure);

                TrianglePath.Data = geometry;
                
                
            }

        }

        private void SideABox_TextChanged(object sender, TextChangedEventArgs e)
        {

            CreateTriangle();
        }
    }
}
