using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class ShapeSystem
    {
        BasicShape[] shapes;
        int shapesCount;
        public ShapeSystem(int amount)
        {
            this.shapes = new BasicShape[amount];
            shapesCount = 0;
        }
        public void Add(BasicShape shape)
        {
            if(shapesCount <= shapes.Length)
            {
                this.shapes[shapesCount] = shape;
                shapesCount++;
            }
        }
        public void PrintDetails()
        {
            for(int i = 0; i < this.shapesCount; i++)
            {
                this.shapes[i].PrintDetails();
                Console.WriteLine("------------------");
            }
        }
        public double GetArea()
        {
            double sum = 0;
            for(int i =0; i < this.shapesCount; i++)
            {
                sum += this.shapes[i].GetArea();
            }
            return sum;
        }
        public double GetPerimeter()
        {
            double sum = 0;
            for (int i = 0; i < this.shapesCount; i++)
            {
                sum += this.shapes[i].GetPerimeter();
            }
            return sum;
        }
        public void Draw()
        {
            for(int i = 0;i < this.shapesCount;i++)
            {
                this.shapes[i].Draw();
                Console.WriteLine("");
            }
        }
        public void Draw(string type)
        {
            for(int i = 0; i < this.shapesCount; i++)
            {
                if (this.shapes[i].GetType().Name== type)
                {
                    this.shapes[i].Draw();
                }
            }
        }
        public void Report()
        {
            int[] shapesTypes = new int[4];
            for(int i = 0; i < this.shapesCount; i++)
            {
                if (this.shapes[i] is Rectangle)
                {
                    shapesTypes[0]++;
                }
                else if (shapes[i] is Circle)
                {
                    shapesTypes[1]++;
                }
                else if (shapes[i] is RightAngledTriangle)
                {
                    shapesTypes[2]++;
                }
                else if (shapes[i] is Cylinder)
                {
                    shapesTypes[3]++;
                }
                Console.WriteLine("Rectangle count: " + shapesTypes[0]);
                Console.WriteLine("Circle count: " + shapesTypes[1]);
                Console.WriteLine("Right Angled Triangle count: " + shapesTypes[2]);
                Console.WriteLine("Cylinder count: " + shapesTypes[3]);
            }
        }

    }
}
