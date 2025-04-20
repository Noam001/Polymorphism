using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Insert The Maximum number of shapes");
            int amount = int.Parse(Console.ReadLine());
            ShapeSystem system = new ShapeSystem(amount);
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Insert The Type Of Shape {i + 1}:");
                Console.WriteLine("1 - Rectangle\n2 - Circle\n3 - Right Angled Triangle\n4 - Cylinder");
                int type = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert Y");
                int y = int.Parse(Console.ReadLine());
                Point p = new Point(x, y);
                Console.WriteLine("Insert Border Color");
                int borderColor = int.Parse(Console.ReadLine());
                Console.WriteLine("Insert Fill Color");
                int fillColor = int.Parse(Console.ReadLine());
                if (type == 1)
                {
                    Console.WriteLine("Insert width");
                    int width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insert height");
                    int height = int.Parse(Console.ReadLine());
                    Rectangle r = new Rectangle(p, borderColor, fillColor, width, height);
                    system.Add(r);
                }
                else if (type == 2) // Circle
                {
                    Console.Write("רדיוס: ");
                    int radius = int.Parse(Console.ReadLine());
                    Circle c = new Circle(p, borderColor, fillColor, radius);
                    system.Add(c);
                }
                else if (type == 3) // RightAngledTriangle
                {
                    Console.Write("A:");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("B:");
                    int b = int.Parse(Console.ReadLine());
                    RightAngledTriangle t = new RightAngledTriangle(borderColor, p, fillColor, a, b);
                    system.Add(t);
                }
                else if (type == 4) // Cylinder
                {
                    Console.Write("Radius: ");
                    int radius = int.Parse(Console.ReadLine());
                    Console.Write("Height:");
                    int height = int.Parse(Console.ReadLine());
                    Cylinder cyl = new Cylinder(p, radius, height);
                    cyl.SetBorderColor(borderColor);
                    cyl.SetFillColor(fillColor);
                    system.Add(cyl);
                }
            }
            system.PrintDetails();
            Console.WriteLine($" The Area of all the shapes is {system.GetArea()}");
            Console.WriteLine($" The Area of all the shapes is {system.GetPerimeter()}");
            system.Draw();
            Console.WriteLine("Insert type of shape");
            string str = Console.ReadLine();
            system.Draw(str);
            system.Report();
            Console.ReadLine();
        }
    }
}
