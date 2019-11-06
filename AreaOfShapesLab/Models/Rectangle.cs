namespace AreaOfShapesLab
{
    class Rectangle : Models.Shape
    {
        private double Width { get; set; }
        private double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea()
        {
            SurfaceArea = Width * Length;
            return SurfaceArea;
        }
    }
}
