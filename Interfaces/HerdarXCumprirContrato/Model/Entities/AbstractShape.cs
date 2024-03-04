using HerdarXCumprirContrato.Model.Enums;

namespace HerdarXCumprirContrato.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();

    }
}
