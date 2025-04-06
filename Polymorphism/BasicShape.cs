using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class BasicShape
    {
        int borderColor;
        Point point;
        int fillColor;
        public BasicShape(int borderColor, Point point, int fillColor)
        {
            this.borderColor = borderColor;
            this.point = point;
            this.fillColor = fillColor;
        }

    }
}
