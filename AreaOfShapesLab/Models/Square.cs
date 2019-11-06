using System;

namespace AreaOfShapesLab
{
    class Square : Models.Shape
    {
        private double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            SurfaceArea = Math.Pow(Side, 2);
            return SurfaceArea;
        }
    }
}
