using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Triangle : Figure
    {
        public double length { get; set; } = 0;
        public double lengthA { get; set; } = 0;
        public double lengthB { get; set; } = 0;
        public bool rectangular { get; set; }

        public Triangle(double _length, double _lengthA, double _lengthB)
        {
            length = _length;
            lengthA = _lengthA;
            lengthB = _lengthB;
            Area = GetAreaTriangle();
            typeFigure = "Треугольник";
        }

        //Вычислить площадь треугольника
        public double GetAreaTriangle()
        {
            if (lengthA == 0 || lengthB == 0) return 0;
            else
            {
                double p = (length + lengthA + lengthB) / 2;
                return Math.Sqrt(p * (p - length) * (p - lengthA) * (p - lengthB));
            }
        }

        public bool CheckRectangular()
        {
            if (lengthA == 0 || lengthB == 0) return false;
            else
            {
                if ((length * length) + (lengthA * lengthA) == (lengthB * lengthB) ||
                    (length * length) + (lengthB * lengthB) == (lengthA * lengthA) ||
                    (lengthB * lengthB) + (lengthA * lengthA) == (length * length))
                {
                    rectangular = true;
                    return true;
                }
                else
                {
                    rectangular = false;
                    return false;
                }
            }
        }
    }
}
