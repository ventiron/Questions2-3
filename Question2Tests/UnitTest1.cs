using Questions2_3;

namespace Question2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleArea()
        {
            double side1 = 5.3;
            double side2 = 4.6;
            double side3 = 5.1;

            Figure triangle = new Triangle(side1, side2, side3);



            double perimeter = side1 + side2 + side3;
            double testArea = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));



            double area = triangle.Area();
            Assert.AreEqual(Math.Round(area,8), Math.Round(testArea, 8)); //Precision - 8 digits
        }

        [TestMethod]
        public void RightTriangleArea()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;

            Figure rightTriangle = new Triangle(side1, side2, side3);



            double testArea = side1 * side2 / 2;



            double area = rightTriangle.Area();
            Assert.AreEqual(Math.Round(area, 8), Math.Round(testArea, 8)); //Precision - 8 digits
        }

        [TestMethod]
        public void CircleArea()
        {
            double radius = 3.514;

            Figure circle = new Circle(radius);



            double testArea = Math.PI * radius * radius;



            double area = circle.Area();
            Assert.AreEqual(Math.Round(area, 8), Math.Round(testArea, 8)); //Precision - 8 digits
        }
    }
}