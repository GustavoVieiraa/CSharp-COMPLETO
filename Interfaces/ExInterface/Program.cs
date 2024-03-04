using ExInterface.Entities;
using ExInterface.Services;
using System;
using System.Globalization;

namespace ExInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre contratos");
            Console.Write("Numero: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de Parcelas: ");
            int meses = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numeroContrato, data, valorContrato);

            ContratoServico contratoServico = new ContratoServico(new ServicoPayPal());
            contratoServico.ProcessoContrato(contrato, meses);

            Console.WriteLine("Parcelas: ");
            foreach (Parcela parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }


        }
    }
}