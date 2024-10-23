using System;
using System.Collections.Generic;

/// <summary>
/// Represents a base class for shapes.
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Gets or sets the color of the shape.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Shape"/> class.
    /// </summary>
    /// <param name="color">The color of the shape.</param>
    protected Shape(string color)
    {
        Color = color;
    }

    /// <summary>
    /// Abstract method to calculate the area of the shape.
    /// </summary>
    /// <returns>The area of the shape.</returns>
    public abstract double GetArea();
}

/// <summary>
/// Represents a square shape.
/// </summary>
public class Square : Shape
{
    private double _side;

    /// <summary>
    /// Initializes a new instance of the <see cref="Square"/> class.
    /// </summary>
    /// <param name="color">The color of the square.</param>
    /// <param name="side">The length of the side of the square.</param>
    public Square(string color, double side)
        : base(color)
    {
        _side = side;
    }

    /// <summary>
    /// Calculates the area of the square.
    /// </summary>
    /// <returns>The area of the square.</returns>
    public override double GetArea()
    {
        return _side * _side;
    }
}

/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : Shape
{
    private double _length;
    private double _width;

    /// <summary>
    /// Initializes a new instance of the <see cref="Rectangle"/> class.
    /// </summary>
    /// <param name="color">The color of the rectangle.</param>
    /// <param name="length">The length of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    public Rectangle(string color, double length, double width)
        : base(color)
    {
        _length = length;
        _width = width;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public override double GetArea()
    {
        return _length * _width;
    }
}

/// <summary>
/// Represents a circle shape.
/// </summary>
public class Circle : Shape
{
    private double _radius;

    /// <summary>
    /// Initializes a new instance of the <see cref="Circle"/> class.
    /// </summary>
    /// <param name="color">The color of the circle.</param>
    /// <param name="radius">The radius of the circle.</param>
    public Circle(string color, double radius)
        : base(color)
    {
        _radius = radius;
    }

    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

/// <summary>
/// Entry point for the Shapes Area Calculator program.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        bool continueAddingShapes = true;

        Console.WriteLine("Welcome to the Shapes Area Calculator!");

        while (continueAddingShapes)
        {
            Console.WriteLine("Choose a shape to add:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Finish and calculate areas");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the color of the square: ");
                    string squareColor = Console.ReadLine();
                    Console.Write("Enter the length of the side: ");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Square(squareColor, squareSide));
                    break;

                case "2":
                    Console.Write("Enter the color of the rectangle: ");
                    string rectangleColor = Console.ReadLine();
                    Console.Write("Enter the length: ");
                    double rectangleLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the width: ");
                    double rectangleWidth = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Rectangle(rectangleColor, rectangleLength, rectangleWidth));
                    break;

                case "3":
                    Console.Write("Enter the color of the circle: ");
                    string circleColor = Console.ReadLine();
                    Console.Write("Enter the radius: ");
                    double circleRadius = Convert.ToDouble(Console.ReadLine());
                    shapes.Add(new Circle(circleColor, circleRadius));
                    break;

                case "4":
                    Console.WriteLine("\nCalculating areas...");
                    foreach (Shape shape in shapes)
                    {
                        Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
                    }
                    continueAddingShapes = false; // Exit the loop
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
            Console.WriteLine(); // Add a blank line for better readability
        }

        Console.WriteLine("Thank you for using the Shapes Area Calculator!");
    }
}