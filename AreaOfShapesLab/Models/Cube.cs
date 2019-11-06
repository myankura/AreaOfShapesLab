using System;

namespace AreaOfShapesLab
{
    class Cube : Models.Shape
    {
        private double Face { get; set; }

        public Cube(double face)
        {
            Face = face;
        }

        public override double CalculateArea()
        {
            SurfaceArea = 6 * (Math.Pow(Face, 2));
            return SurfaceArea;
        }
    }
}
