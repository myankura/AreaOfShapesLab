using System;

namespace AreaOfShapesLab
{
    class Sphere : Models.Shape
    {
        private double Radius { get; set; }

        private readonly double Pi = Math.PI;

        public Sphere(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            SurfaceArea = 4 * Math.Pow((Pi * Radius), 2);
            return SurfaceArea;
        }
    }
}
