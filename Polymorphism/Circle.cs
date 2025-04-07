using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Circle: BasicShape
    {
        int radius;
        public Circle(Point center, int borderColor, int fillColor, int radius):
            base(borderColor, center, fillColor)
        {
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Display Circle impossibility in Console Applications");
        }

        public override double GetArea()
        {
            return 3.14 * Math.Pow(this.radius, 2);
        }

        public override double GetPerimeter()
        {
            return this.radius* 2 * 3.14;
        }

       
        public override string ToString()
        {
            return $"Circle Details:\n" +
                $"Radius: {this.radius}" +
                $"Point : ({this.point.GetX()}, {this.point.GetY()})\n" +
                $"Border Color: {this.borderColor}\n" +
                $"Fill Color:{this.fillColor}";
        }
    }
}
