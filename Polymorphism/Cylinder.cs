using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Polymorphism
{
    internal class Cylinder : Circle
    {
        private int height;
        public Cylinder(Point center, int radius, int height) : base(center, 0, 0, radius)//צבעים לא צוינו- מסומנים כ0 - ברירת מחדל
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public override double GetArea()
        {
            return (2* 3.14* this.radius) + (this.height+ this.radius);
        }
        public double GetVolume()
        {
            return 3.14 * Math.Pow(this.radius, 2)* this.height;
        }
        public override void Draw()
        {
            Console.WriteLine("Display Cylinder impossibility in Console Applications");
        }
    }
}
