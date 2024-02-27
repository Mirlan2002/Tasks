using AreaCalculation.Interfaces;

namespace AreaCalculation.Implementations
{
    /// <summary>
    /// Класс описывающий круг
    /// </summary>
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        ///<inheritdoc/>
        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
