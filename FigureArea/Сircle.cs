using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public class Circle: Figure
    {
        public double radius { get; set; } = 0;
        public Circle()
        {

        }
        public Circle(double _radius)
        {
            radius = _radius;
            Area = GetAreaСircle();
            typeFigure = "Круг";
        }

        //Вычислить площадь круга
        public double GetAreaСircle()
        {
            return radius * radius * Math.PI;
        }
    }
    
}
