using System;

namespace ToyMvvm.Model
{
    public class Formula
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Formula(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double Calculate(double x)
        {
            return Math.Pow(_a, 2) * x + _b * x + _c;
        }
    }
}
