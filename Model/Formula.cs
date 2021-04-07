using System;

namespace ToyMvvm.Model
{
    public class Formula
    {
        public Formula(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; }

        public double B { get; }

        public double C { get; }

        public double Calculate(double x)
        {
            return Math.Pow(A, 2) * x + B * x + C;
        }
    }
}
