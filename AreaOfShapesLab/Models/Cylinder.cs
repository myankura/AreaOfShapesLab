using System;

namespace AreaOfShapesLab
{
    class Cylinder : Models.Shape
    {
        private double Height { get; set; }
        private double Radius { get; set; }

        private readonly double Pi = Math.PI;

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public override double CalculateArea()
        {
            SurfaceArea = 2 * (Pi * Radius * Height) + 2 * (Pi * Math.Pow(Radius, 2));
            return SurfaceArea;
        }
    }
}
