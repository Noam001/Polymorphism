using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Rectangle: BasicShape
    {
        double height;
        double width;
        public Rectangle(Point point, int borderColor, int fillColor, int width, int height):
            base(borderColor,point, fillColor)
        {
            this.height = height;
            this.width = width;
        }

        public override double GetArea()
        {
            return this.height * this.width;
        }

        public override void Draw()
        {
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    
                    ConsoleColor bordercolor = (ConsoleColor)this.borderColor;
                    ConsoleColor fill = (ConsoleColor)this.fillColor;
                    if (i == 0 || i== this.height-1 || j==0 || j== this.width-1)
                    {
                        Console.ForegroundColor = bordercolor;
                    }
                    else
                    {
                        Console.ForegroundColor = fill;
                    }
                    Console.SetCursorPosition(this.point.GetX() + j, this.point.GetY() + i);
                    Console.Write("█");
                }
            }
        }

        public override double GetPerimeter()
        {
            return 2 * (this.width + this.height);
        }
        public override string ToString()
        {
            return $"Rectangle Details:\n" +
                $"Height: {this.height}, Width: {this.width}\n" +
                $"Point : ({this.point.GetX()}, {this.point.GetY()})\n" +
                $"Border Color: {this.borderColor}\n" +
                $"Fill Color:{this.fillColor}";
        }
    }
}
