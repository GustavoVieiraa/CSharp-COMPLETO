using System;
using System.Globalization;

namespace HerdarXCumprirContrato.Model.Entities
{
    internal class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return $"=-------------------------------------="
                + $"\nCircle Color {Color}"
                + $"\n Radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\n Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\n=-------------------------------------=";
        }

    }
}
