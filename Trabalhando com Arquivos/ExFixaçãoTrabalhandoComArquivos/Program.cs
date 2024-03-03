using ExFixaçãoTrabalhandoComArquivos.Entities;
using System;
using System.IO;
using System.Globalization;

/*
 
            ### Exercício - Trabalhando com Arquivos by Gusta x:II

    Fazer um programa para ler o caminho de um arquivo .csv contendo os dados
    de itens vendidos. Cada item possui um nome, preço unitário e quantidade,
    separados por vírgula. Você deve gerar um novo arquivo chamado "summary.csv",
    localizado em uma subpasta chamada "out" a partir da pasta original do arquivo
    de origem, contendo apenas o nome e o valor total para aquele item (preço
    unitário multiplicado pela quantidade).
 
 */


namespace ExArquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre com o caminho da pasta: ");
            string dadosArquivo = Console.ReadLine();

            try
            {
                string[] linhas = File.ReadAllLines(dadosArquivo);
                string pastaInicial = Path.GetDirectoryName(dadosArquivo);
                string novaPastaOut = pastaInicial + @"\out";
                string arquivoSaida = novaPastaOut + @"\summary.txt";
                
                Directory.CreateDirectory(novaPastaOut);

                using (StreamWriter sw = File.AppendText(arquivoSaida))
                {
                    foreach (string line in linhas)
                    {
                        string[] fields = line.Split(',');
                        string nome = fields[0];
                        double preco = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(fields[2]);

                        Product product = new Product(nome, preco, quantidade);

                        sw.WriteLine($"{product.Nome}, {product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }

                

            }
            catch (IOException e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }

        }
    }
}