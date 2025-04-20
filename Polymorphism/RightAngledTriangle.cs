using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class RightAngledTriangle : BasicShape
    {
        int a;
        int b;
        string direction;
        public RightAngledTriangle(int borderColor, Point point, int fillColor, int a, int b) : base(borderColor, point, fillColor)
        {
            this.a = a;
            this.b = b;
        }

        public override void Draw()
        {
            for (int row = 0; row < b; row++)
            {
                int colsInRow = (int)Math.Round((double)(a) * (row + 1) / b);

                int xPosStart = this.point.GetX();

                for (int col = 0; col < colsInRow; col++)
                {
                    int xPos = xPosStart + col;
                    if (xPos < 0) xPos = 0;

                    Console.SetCursorPosition(xPos, this.point.GetY() + row);
                    bool isBorder = row == b - 1 || col == 0 || col == colsInRow - 1;

                    if (isBorder)
                    {
                        Console.ForegroundColor = (ConsoleColor)this.borderColor;
                    }
                    else
                    {
                        Console.ForegroundColor = (ConsoleColor)this.fillColor;
                    }
                    Console.Write("█");
                }
            }
        }

        public override double GetArea()
        {
            return (this.a * this.b) / 2;
        }

        public override double GetPerimeter()
        {
            return (this.a + this.b) + (Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2)));
        }
        public override string ToString()
        {
            return $"RightAngledTriangle Details\n" +
                $"Point : {(point.GetX(), point.GetY())}\n" +
                $"A: {this.a}\n" +
                $"B: {this.b}\n" +
                $"Border Color:{this.borderColor}\n" +
                $"Fill Color: {this.fillColor}\n" +
                $"Direction: {this.direction}";

        }
    }
}
