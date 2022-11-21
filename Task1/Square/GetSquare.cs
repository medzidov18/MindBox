namespace Square
{
    public class GetSquare
    {
        public abstract class Figure
        {
            public string[] figures = { "Сircle", "Triangle"};

            public abstract double SquareOfFigure();
        }

        public class Circle : Figure
        {
            public string nameOfFigure { get; set; }

            double radius = 0;

            public Circle(double Radius)
            {
                nameOfFigure = figures[0];    
                radius = Radius;
            }

            public override double SquareOfFigure()
            {
                double result = 0;
                
                if (nameOfFigure == figures[0] && radius > 0)
                {
                    result = Math.PI * Math.Pow(radius, 2);
                    Console.Write("The square of this circle is: ");
                }
                else
                {
                    throw new ArgumentException("The radius must be bigger than zero!!!");
                }

                return result;
            }
        }

        public class Triangle : Figure
        {
            public string nameOfFigure { get; set; }

            public double side1 { get; set; }
            public double side2 { get; set; }
            public double side3 { get; set; }


            public Triangle(double Side1, double Side2, double Side3)
            {
                nameOfFigure = figures[1];
                side1 = Side1;
                side2 = Side2;
                side3 = Side3;
            }

            public void isTriangle(double side1, double side2, double side3)
            {
                double maxSide = new[] { side1, side2, side3 }.Max();
                double perimeter = side1 + side2 + side3;

                if (perimeter - (2 * maxSide) <= 0)
                {
                    throw new ArgumentException("This is not a triangle!");
                }

            }

            public void isRectangular(double side1, double side2, double side3)
            {
                bool isRectangular = false;

                double maxSide = new[] { side1, side2, side3 }.Max();


                if (maxSide == side1)
                {
                    if (Math.Pow(side1, 2) == (Math.Pow(side2, 2) + Math.Pow(side3, 2)))
                    {
                        isRectangular = true;
                    }
                }

                if (maxSide == side2)
                {
                    if (Math.Pow(side2, 2) == (Math.Pow(side1, 2) + Math.Pow(side3, 2)))
                    {
                        isRectangular = true;
                    }
                }

                if (maxSide == side3)
                {
                    if (Math.Pow(side3, 2) == (Math.Pow(side2, 2) + Math.Pow(side1, 2)))
                    {
                        isRectangular = true;
                    }
                }

                if (isRectangular)
                {
                    Console.Write("Triangle is Rectangular, and his Square is: ");
                }
                else
                {
                    Console.Write("Triangle is not Rectangular, and his Square is: ");    
                }
            }

            public override double SquareOfFigure()
            {
                double result = 0;
                double halfPerimeter = 0;

                isTriangle(side1, side2, side3);
                isRectangular(side1, side2, side3);
                

                if (side1 > 0 && side2 > 0 && side3 > 0)
                {
                    if (nameOfFigure == figures[1])
                    {
                        halfPerimeter = (side1 + side2 + side3) / 2;
                        result = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
                    }
                }

                return result;
            }
        }
    }
}