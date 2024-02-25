using System;
using System.Globalization;
using System.Numerics;
using ExImpostoContribuintes.Entities;
/*
 
        # Exercicio Proposto - by gusta x:II
    Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais podem ser pessoa
    jurídica, e depois mostrar o valor do imposto pago por cada um, bem como o total de imposto arrecadado.

    Os dados de pessoa física são: nome, renda atual e gastos com saúde. Os dados de pessoa jurídica são
    nome, renda anual e número de funcionários. As regras para cálculo de imposto são as seguintes:

    - Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com renda de 20000.00
    em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
    exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica:
    (50000 * 25%) - (2000 * 50%) = 11500.00

    - Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 funcionários,
    ela paga 14% de imposto.
    exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
    400000 * 14% = 56000.00
 */

namespace ImpostoContribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=----------- Calculadora de Impostos -----------=");
            Console.Write("Entre com o número de pagadores de impostos: ");
            int nPagadores = int.Parse(Console.ReadLine());

            List<Pessoa> pagadores = new List<Pessoa>();

            for (int i = 1; i <= nPagadores; i++)
            {
                Console.WriteLine($"Pagador de imposto #{i}");
                Console.Write("Pessoa física ou Pessoa Juridica (f/j): ");
                char tipoPagador = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch ( tipoPagador )
                {
                    case 'f':
                        Console.Write("Gastos com saúde: ");
                        double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        pagadores.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                        break;
                    case 'j':
                        Console.Write("Quantidade de funcionários: ");
                        int nFuncionarios = int.Parse(Console.ReadLine());
                        pagadores.Add(new PessoaJuridica(nome, rendaAnual, nFuncionarios));
                        break;
                }
            }

            Console.WriteLine();

            Console.WriteLine("IMPOSTOS PAGOS: ");

            double totImpostos = 0.0;

            foreach (Pessoa pagadora in pagadores)
            {
                 totImpostos += pagadora.ImpostoRenda();
                Console.WriteLine(pagadora.DescricaoPagamento());
            }
            Console.WriteLine();
            Console.WriteLine($"Total de impostos: {totImpostos}");
        }
    }
}