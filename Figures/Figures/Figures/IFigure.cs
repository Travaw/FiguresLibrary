using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea.Figures
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Получить периметр фигуры
        /// </summary>
        /// <returns></returns>
        double GetPerimeter();

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns></returns>
        double GetArea();
    }
}
