using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class RightAngledTriangle:BasicShape
    {
        int a;
        int b;
        string direction;
        public RightAngledTriangle(Point rightHighPoint, int BorderColor, int fillColor, int a, int b):base(BorderColor, rightHighPoint, fillColor)
        {
            this.a = a;
            this.b = b;
        }

        public override void Draw()
        {

        }

        public override double GetArea()
        {
            return (this.a * this.b) /2;
        }

        public override double GetPerimeter()
        {
            return (this.a + this.b) +(Math.Sqrt(Math.Pow(this.a,2)+Math.Pow(this.b,2)));
        }

    }
}
