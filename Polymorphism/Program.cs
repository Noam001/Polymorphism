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
            Point p = new Point(0, 0);
            BasicShape shape = new RightAngledTriangle(p,14,2,7,9);
            shape.Draw();
            Console.ReadLine();
        }
    }
}
