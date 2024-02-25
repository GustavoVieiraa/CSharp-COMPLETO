using ExMetodosAbstratos.Entities;
using System;
using ExMetodosAbstratos.Entities.Enums;
using System.Globalization;


/*
                # Exercicio Proposto
    Fazer um programa para ler os dados de N figuras
    (N fornecido pelo usuário), e depois mostrar as
    áreas destas figuras na mesma ordem em que foram
    digitadas.
 
 */

namespace CompShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int nShapes = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();

            for (int i = 1; i <= nShapes; i++)
            {
                Console.WriteLine("=---------------------=");
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                char typeShape = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                switch (typeShape)
                {
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Circle(radius, color));
                        break;
                }
            }

            Console.WriteLine("=---------------------=");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("SHAPES AREAS: ");
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}