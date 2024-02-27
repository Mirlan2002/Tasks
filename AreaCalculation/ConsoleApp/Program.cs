using AreaCalculation.Implementations;
using AreaCalculation.Interfaces;

IFigure triangle = new Triangle(3, 4, 5);
IFigure circle = new Circle(3);

Console.WriteLine("Triangle area: " + triangle.GetArea() + "\nCircle area: " + circle.GetArea());
