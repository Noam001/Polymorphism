using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Point p = new Point(10, 10);
            BasicShape shape = new Rectangle(p,14,2,13,10);
            shape.PrintDetails();
        }
    }
}
