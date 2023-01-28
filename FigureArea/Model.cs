using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Model
    {
        public Circle? circle { get; set; }
        public Triangle? triangle { get; set; }
        public double area { get; set; } = 0;
        public string typeFigure { get; set; } = "";

        public Model(double radius)
        {
            circle = new Circle(radius);
            area = circle.Area;
            typeFigure = circle.typeFigure;
        }
        public Model(double length, double lengthA, double lengthB)
        {
            triangle = new Triangle(length, lengthA, lengthB);
            area = triangle.Area;
            typeFigure = triangle.typeFigure;
        }
    }
}
