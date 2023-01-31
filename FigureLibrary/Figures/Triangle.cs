using System;

namespace FigureLibrary.Figures
{
    public class Triangle : Figure
    {
        public double SideA { get; init; }
        public double SideB { get; init; }
        public double SideC { get; init; }

        public Triangle()
        {
            SideA = 0;
            SideB = 0;
            SideC = 0;
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;    
            SideC = sideC;
        }

        public override double GetSquare()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool RectificationCheck()
        {
            return ((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)) ||
                (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)) ||
                (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2)));

        }

        public override string ToString()
        {
            return "Side A: " + SideA + ", Side B: " + SideB + ", Side C: " + SideC;
        }

        public override bool Equals(Object obj)
        {
            if (obj is Triangle triangle)
            {
                return triangle.SideA == SideA &&
                    triangle.SideB == SideB &&
                    triangle.SideC == SideC;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return SideA.GetHashCode() ^ SideB.GetHashCode() ^ SideC.GetHashCode();
        }
    }
}
