using System;

namespace AreaOfShapesLab.Models
{
    public abstract class Shape
    {
        public double SurfaceArea { get; set; }

        public abstract double CalculateArea(); 
    }
}
