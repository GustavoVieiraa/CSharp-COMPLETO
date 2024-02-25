using System;
using System.Collections.Generic;
using ExMetodosAbstratos.Entities.Enums;


namespace ExMetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        // public Shape() { }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        

    }
}
