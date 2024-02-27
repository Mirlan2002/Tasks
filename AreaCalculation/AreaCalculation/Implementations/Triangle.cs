using AreaCalculation.Interfaces;

namespace AreaCalculation.Implementations
{
    /// <summary>
    /// Класс описывающий треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Сторона A
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; set; }

        ///<inheritdoc/>
        public double GetArea()
        {
            //Площадь находим по формуле Герона
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle()
        {
            var sides = new double[] { A, B, C };
            var orderedSides = sides.Order();
            return (Math.Pow(orderedSides.ElementAt(0), 2) + Math.Pow(orderedSides.ElementAt(1), 2)) == Math.Pow(orderedSides.ElementAt(2), 2);
        }
    }
}
