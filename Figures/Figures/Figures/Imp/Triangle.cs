namespace FigureArea.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public  record Triangle : Polygon
    {
        /// <summary>
        /// Ctr, принимающий длины трёх сторон
        /// </summary>
        public Triangle(double a, double b, double c) : base(new double[3] { a, b, c }) { }

        /// <inheritdoc/>
        public override double GetArea()
        {
            var halfPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));
        }

        /// <summary>
        /// Проверка треугольника на прямоугольности
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangele()
        {
            var hypotenuse = Sides.Max();
            return Math.Pow(hypotenuse, 2) == Sides.Where(s => s != hypotenuse).Select(s => Math.Pow(s, 2)).Sum();
        }
    }
}
