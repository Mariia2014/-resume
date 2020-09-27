using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreaCalculation.Shapes
{
    public class Range : Interfaces.IShape
    {
        public int Radius { get; set; }

        public double Area => Math.PI * Math.Pow(Radius, 2);

        public Range()
        {
            Radius = default(int);
        }
        public Range(int radius)
        {
            Radius = radius;
        }
    }
}
