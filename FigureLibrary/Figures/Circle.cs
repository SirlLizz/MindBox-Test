using System;

namespace FigureLibrary.Figures
{
    public class Circle : Figure
    {
        public double Radius { get; init; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return 2 * Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return "Radius: " + Radius ;
        }

        public override bool Equals(Object obj)
        {
            if (obj is Circle circle)
            {
                return circle.Radius == Radius;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
}
