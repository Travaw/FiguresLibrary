namespace Figure.Test
{
    internal class TriangleTest
    {
        private Triangle commonTriangle;

        private Triangle rightTriangle;

        private Triangle equilateralTriangle;

        [SetUp]
        public void Setup()
        {
            commonTriangle = new Triangle(5, 6, 7);
            rightTriangle = new Triangle(5, 4, 3);
            equilateralTriangle = new Triangle(5, 5, 5);
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <param name="perimeter">периметр треугольника/param>
        /// <param name="sideA">сторона треугольника</param>
        /// <param name="sideB">сторона треугольника</param>
        /// <param name="sideC">сторона треугольника</param>
        /// <returns></returns>
        private double GetTriangleArea(double perimeter, double sideA, double sideB, double sideC) => Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));

        /// <summary>
        /// Проверка вычисления площади треугольника
        /// </summary>
        [Test]
        public void TestCommonTriangleArea() 
        { 
            Assert.That(commonTriangle.GetArea(), Is.EqualTo(GetTriangleArea(9, 5, 6, 7)));
        }

        /// <summary>
        /// Проверка вычисления площади прямоугольного треугольника
        /// </summary>
        [Test]
        public void TestReightTriangleArea()
        {
            Assert.That(rightTriangle.GetArea(), Is.EqualTo(GetTriangleArea(6, 5, 4, 3)));
        }

        /// <summary>
        /// Проверка вычисления площади равностороннего треугольника
        /// </summary>
        [Test]
        public void TestEquilateralTriangleArea()
        {
            Assert.That(equilateralTriangle.GetArea(), Is.EqualTo(GetTriangleArea(7.5, 5, 5, 5)));
        }

        /// <summary>
        /// Проверка работы метода <see cref="Triangle.IsRightTriangele"/>
        /// </summary>
        [Test]
        public void TestIsRightCommonTriangleArea()
        {
            Assert.That(commonTriangle.IsRightTriangele(), Is.EqualTo(false));
        }

        /// <summary>
        /// Проверка работы метода <see cref="Triangle.IsRightTriangele"/>
        /// </summary>
        [Test]
        public void TestIsRightReightTriangleArea()
        {
            Assert.That(rightTriangle.IsRightTriangele(), Is.EqualTo(true));
        }

        /// <summary>
        /// Проверка работы метода <see cref="Triangle.IsRightTriangele"/>
        /// </summary>
        [Test]
        public void TestIsRightEquilateralTriangleArea()
        {
            Assert.That(equilateralTriangle.IsRightTriangele(), Is.EqualTo(false));
        }
    }
}
