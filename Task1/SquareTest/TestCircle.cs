namespace SquareTest
{
    public class TestCircle
    {
        [Fact]
        public void RadiusAreEqualZeroTest()
        {
            //Arrange
            double radius = 0;

            //Act
            var circle = new GetSquare.Circle(radius);

            //Assert
            Assert.Throws<ArgumentException>(() => circle.SquareOfFigure());
        }

        [Fact]
        public void RadiusAreLessThanZeroTest()
        {
            //Arrange
            double radius = -22.5;

            //Act
            var circle = new GetSquare.Circle(radius);

            //Assert
            Assert.Throws<ArgumentException>(() => circle.SquareOfFigure());
        }

        [Fact]
        public void GetSquareOfCircleTest()
        {
            //Arrange
            double radius = 8;
            var Expected = Math.PI * Math.Pow(radius, 2);

            //Act
            var circle = new GetSquare.Circle(radius);
            var square = circle.SquareOfFigure();

            //Assert
            Assert.Equal(Expected, square);

        }
    }
}