namespace AreaOfShapesLab
{
    class Triangle : Models.Shape
    {
        private double Height { get; set; }
        private double Base { get; set; }

        public Triangle(double triangleBase, double triangleHeight)
        {
            Base = triangleBase;
            Height = triangleHeight;
        }

        public override double CalculateArea()
        {
            SurfaceArea = (Base * Height) / 2;
            return SurfaceArea;
        }
    }
}
