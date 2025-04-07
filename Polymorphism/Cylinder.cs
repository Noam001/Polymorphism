using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Cylinder: Circle
    {
        private int height;
        public Cylinder(Point center,int height, int radius): base(center,radius)
        {
            this.height = height;
        }
    }
}
