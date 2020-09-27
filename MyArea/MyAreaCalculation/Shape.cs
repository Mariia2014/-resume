using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAreaCalculation.Shapes
{
    public class Shape : Interfaces.IShape
    {
        private Interfaces.IShape shape;
        public double Area => shape.Area;

        public Shape(Interfaces.IShape figure)
        {
            shape = figure;
        }
    }
}
