using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest
{
    public class TestTriangle
    {
        [Fact]
        public void isNotTriangleTest()
        {
            //Arrange
            double side1 = 1;
            double side2 = 5;
            double side3 = 10;

            //Act
            var triangle = new GetSquare.Triangle(side1, side2, side3);

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.SquareOfFigure());
        }

        [Fact]
        public void TriangleWithNegativeSidesTest()
        {
            //Arrange
            double side1 = -3;
            double side2 = 4;
            double side3 = 5;

            //Act
            var triangle = new GetSquare.Triangle(side1, side2, side3);

            //Assert
            Assert.Throws<ArgumentException>(() => triangle.SquareOfFigure());
        }

        [Fact]
        public void GetSquareOfTriangleTest()
        {
            //Arrange
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            double halfPerimeter = (side1 + side2 + side3) / 2;
            double squareExpected = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));

            //Act
            var triangle = new GetSquare.Triangle(side1, side2, side3);
            var square = triangle.SquareOfFigure();

            //Assert
            Assert.NotNull(square);
            Assert.Equal(squareExpected, square);
        }
    }
}
