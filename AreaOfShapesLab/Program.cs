using System;
using System.Threading;

namespace AreaOfShapesLab
{
    class Program
    {
        static void DisplayBanner()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                 Find the area of a shape
        +-++-++-++-++-++-++-++-++-++-++-++-++-+");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            Rectangle Rectangle;
            Square Square;
            Cube Cube;
            Circle Circle;
            Sphere Sphere;
            Triangle Triangle;
            Cylinder Cylinder;

            while (true)
            {
                
                DisplayBanner();

                //Give the user options to select from.
                Console.WriteLine("1. Rectangle");
                Console.WriteLine("2. Square");
                Console.WriteLine("3. Cube");
                Console.WriteLine("4. Circle");
                Console.WriteLine("5. Sphere");
                Console.WriteLine("6. Triangle");
                Console.WriteLine("7. Cylinder");
                Console.WriteLine("8. Exit");

                Console.WriteLine("\nWhich shape would you like to have me calculate the area for?");
                Console.WriteLine("Everything is measured in inches by default.\n");
                Console.WriteLine("> ");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    //area of a rectangle
                    //get the length
                    Console.WriteLine("Please enter the length of the rectangle in inches");
                    Console.Write("> ");
                    var length = double.Parse(Console.ReadLine());

                    //get the width
                    Console.WriteLine("\nPlease enter the width of the rectangle in inches");
                    Console.Write("> ");
                    var width = double.Parse(Console.ReadLine());

                    Rectangle = new Rectangle(length, width);
                    var area = Rectangle.CalculateArea();

                    Console.WriteLine($"\nThe area of the rectangle is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();

                }
                else if (option == "2")
                {
                    //rectangle of a square
                    //get the side length
                    Console.WriteLine("Please enter the length a side of the square in inches.");
                    Console.Write("> ");
                    var side = double.Parse(Console.ReadLine());

                    Square = new Square(side);
                    var area = Square.CalculateArea();

                    Console.WriteLine($"\nThe area of the square is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();

                }
                else if (option == "3")
                {
                    //area of a cube
                    //get the value of one the faces on the square
                    Console.WriteLine("Please enter the value of one face of the cube in inches.");
                    Console.Write("> ");
                    var face = double.Parse(Console.ReadLine());

                    Cube = new Cube(face);
                    var area = Cube.CalculateArea();

                    Console.WriteLine($"\nThe area of the cube is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();

                }
                else if (option == "4")
                {
                    //circle
                    //get the radius of the circle
                    Console.WriteLine("Please enter the radius of the circle in inches.");
                    Console.Write("> ");
                    var radius = double.Parse(Console.ReadLine());

                    Circle = new Circle(radius);
                    var area = Circle.CalculateArea();

                    Console.WriteLine($"\nthe area of the circle is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();
                }
                else if (option == "5")
                {
                    //sphere
                    //get the radius of the sphere
                    Console.WriteLine("Please enter the radius of the sphere in inches.");
                    Console.Write("> ");
                    var radius = double.Parse(Console.ReadLine());

                    Sphere = new Sphere(radius);
                    var area = Sphere.CalculateArea();

                    Console.WriteLine($"\nThe area of the sphere is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();
                }
                else if (option == "6")
                {
                    //triangle
                    //get the base of the triangle
                    Console.WriteLine("Please enter the base of the triangle in inches.");
                    Console.Write("> ");
                    var tBase = double.Parse(Console.ReadLine());

                    //get the height of the triangle
                    Console.WriteLine("\nPlease enter the height of the triangle in inches.");
                    Console.Write("> ");
                    var tHeight = double.Parse(Console.ReadLine());

                    Triangle = new Triangle(tBase, tHeight);
                    var area = Triangle.CalculateArea();

                    Console.WriteLine($"\nThe area of the triangle is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();
                }
                else if (option == "7")
                {
                    //Cylinder
                    //get the radius
                    Console.WriteLine("Please enter the radius of the cylinder in inches.");
                    Console.Write("> ");
                    var radius = double.Parse(Console.ReadLine());

                    //get the height
                    Console.WriteLine("\nPlease enter the height of the cylinder in inches.");
                    Console.Write("> ");
                    var height = double.Parse(Console.ReadLine());

                    Cylinder = new Cylinder(radius, height);
                    var area = Cylinder.CalculateArea();

                    Console.WriteLine($"\nThe area of the cylinder is {area} inches.");
                    Console.WriteLine($"Press enter to clear the result.");
                    Console.ReadLine();
                }
               
                else if (option == "8")
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid option: {option}");
                }
            }
        }
    }
}
