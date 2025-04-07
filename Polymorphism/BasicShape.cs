using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal abstract class BasicShape
    {
        protected int borderColor;
        protected Point point;
        protected int fillColor;
        public BasicShape(int borderColor, Point point, int fillColor)
        {
            this.borderColor = borderColor;
            this.point = point;
            this.fillColor = fillColor;
        }
        public int GetBorderColor()
        {
            return this.borderColor;
        }
        public void SetBorderColor(int borderColor)
        {
            this.borderColor = borderColor;
        }
        public Point GetPoint()
        {
            return this.point;
        }
        public void SetPoint(Point point)
        {
            this.point = point;
        }
        public int GetFillColor()
        {
            return this.fillColor;
        }
        public void SetFillColor(int fillColor)
        {
            this.fillColor = fillColor;
        }

        public  void PrintDetails()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Draw();
    }

}
