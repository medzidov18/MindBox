using System;
using Square;

class Program
{
    static void Main(string[] args)
    {
        GetSquare.Circle circle = new GetSquare.Circle(4d);
        GetSquare.Triangle tr = new GetSquare.Triangle(3d, 4d, 5d);
        Console.WriteLine(tr.SquareOfFigure());
        Console.WriteLine(circle.SquareOfFigure());
    }
}