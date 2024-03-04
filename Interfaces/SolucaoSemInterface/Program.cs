using System;
using System.Globalization;
using SolucaoSemInterfaceP1.Entities;
using SolucaoSemInterfaceP1.Services;

namespace SemInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string modelCar = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            CarRental carRental = new CarRental(start, finish, new Vehicle(modelCar));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");

            Console.WriteLine(carRental.Invoice);
        }
    }
}