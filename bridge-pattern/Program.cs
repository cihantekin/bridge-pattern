// See https://aka.ms/new-console-template for more information
using bridge_pattern.Abstraction;
using bridge_pattern.Implementation;

Console.WriteLine("Hello, World!");

// Lets create a red triangle 
var redTriangle = new Triangle(new Red());
Console.Write(redTriangle.GetShapeDescription());

Console.Write(Environment.NewLine);

// Lets create a blue rectangle
var blueRectangle = new Rectangle(new Blue());
Console.Write(blueRectangle.GetShapeDescription());