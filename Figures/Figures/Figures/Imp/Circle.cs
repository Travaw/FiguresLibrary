using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public record Circle : IFigure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; init; }

        /// <summary>
        /// Ctr
        /// </summary>
        /// <param name="radius">Радиус круга</param>
        public Circle(ulong radius) 
        {
            Radius = radius;
        }

        /// <inheritdoc/>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);

        /// <inheritdoc/>
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }
}
