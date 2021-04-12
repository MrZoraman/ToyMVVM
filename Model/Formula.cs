using System;

namespace ToyMvvm.Model
{
    public class Formula
    {
        public Formula(Guid id, double a, double b, double c)
        {
            Id = id;
            A = a;
            B = b;
            C = c;
        }

        public Guid Id { get; }

        public double A { get; private set; }

        public double B { get; private set; }

        public double C { get; private set; }

        public double Calculate(double x)
        {
            return Math.Pow(A, 2) * x + B * x + C;
        }

        public void Save(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            // Write to disk, update database, etc... Persist changes.
        }
    }
}
