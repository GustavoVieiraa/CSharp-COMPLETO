using System.Globalization;

namespace HerdarXCumprirContrato.Model.Entities
{
    internal class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"=-------------------------------------="
                + $"\nRectangle color = {Color}"
                + $"\nWidth = {Width.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\nHeight = {Height.ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\nArea = {Area().ToString("F2", CultureInfo.InvariantCulture)}"
                + $"\n=-------------------------------------=";
        }
    }
}
