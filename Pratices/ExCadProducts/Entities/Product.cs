using System;
using System.Globalization;
namespace ExCadProducts.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return Name
                + " - $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
