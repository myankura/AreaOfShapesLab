using System;

namespace AreaOfShapesLab
{
    class Circle : Models.Shape
    {
        private double Radius { get; set; }

        private readonly double Pi = Math.PI;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            SurfaceArea = Radius * Pi;
            return SurfaceArea;
        }
    }
}
