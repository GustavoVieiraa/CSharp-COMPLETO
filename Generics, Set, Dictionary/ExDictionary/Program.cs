using System;
using System.IO;

/*
 
                ### Exercício Proposto###

    Na contagem de votos de uma eleição, são gerados vários
    registros de votação contendo o nome e a quantidade de votos
    (formato .csv) que ele obteve em uma urna de votação. Você
    deve fazer um programa para ler os registros de votação
    a partir de um arquivo, e daí gerar um relatório consolidado
    com os totais de cada candidato.
 
 */


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int votos = int.Parse(line[1]);
                        
                        if (candidatos.ContainsKey(candidato))
                        {
                            candidatos[candidato] += votos;
                        }
                        else
                        {
                            candidatos[candidato] = votos; 
                        }
                    }
                }
                foreach (var candidato in candidatos)
                {
                    Console.WriteLine($"{candidato.Key}: {candidato.Value}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}