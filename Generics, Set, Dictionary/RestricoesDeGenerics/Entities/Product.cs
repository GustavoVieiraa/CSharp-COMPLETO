using System.Globalization;

namespace RestricoesDeGenerics.Entities
{
     class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return 
                $"\n{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Error: This object not is an Product.");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}
