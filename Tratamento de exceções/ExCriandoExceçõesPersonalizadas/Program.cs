using ExCriandoExceçõesPersonalizadas.Entities;
using ExCriandoExceçõesPersonalizadas.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExReservation
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Room Number: ");
                int numberRoom = int.Parse(Console.ReadLine());

                Console.Write("Check-In (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));


                Console.Write("Check-Out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));


                Reservation reservation = new Reservation(numberRoom, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-In (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));


                Console.Write("Check-Out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine(), CultureInfo.CreateSpecificCulture("pt-BR"));

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine($"Reservation: {reservation}");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            } 
            catch (FormatException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }
}