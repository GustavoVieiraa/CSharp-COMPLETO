using System;
using System.IO;

/*
 
                ### Using Block
    Sintaxe simplificada que garante que os objetos
    IDisposable serão fechados.

    Objetos IDisposable NÃO são gerenciados pelo CLR.
    Eles precisam ser manualmente fechados.

    Exemplos: Font, FileStream, StreamReader, StreamWriter.
 
 */


namespace FileUsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\test\file1.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            
        }
    }
}