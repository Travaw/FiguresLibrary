using Figures.Exceptions;

namespace FigureArea.Figures
{
    /// <summary>
    /// Многоугольник
    /// </summary>
    public abstract record Polygon : IFigure
    {
        /// <summary>
        /// Стороны многоугольника
        /// </summary>
        public double[] Sides { get; private set; }

        /// <summary>
        /// Ctr
        /// </summary>
        /// <param name="sides">Массив длин сторон</param>
        protected Polygon(double[] sides) 
        {
            if (sides.Any(s => s <= 0))
            {
                throw new SideLengthNotPositiveNumberException();
            }
            Sides = sides;
        }

        /// <inheritdoc/>
        public abstract double GetArea();

        /// <inheritdoc/>
        public double GetPerimeter()
        {
            return Sides.Sum();
        }
    }
}
