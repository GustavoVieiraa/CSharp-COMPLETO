using System;
using System.IO;

/*
            ### StreamWriter
    É uma stream capaz dde escrever caracteres
    a partir de uma stream binária (ex: FileStream).

    Suporte a dados no formato de texto.

    Instantiation:
        - Several constructors
        - File / FileInfo
            ~ CreateText (path)
            ~ AppendText (string)
 */


namespace CourseFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourceFile = @"C:\temp\file.txt";
            string targetFile = @"C:\temp\fileTeste.txt";

            try
            {

                string[] lines = File.ReadAllLines(sourceFile);

                using (StreamWriter sw = File.AppendText(targetFile))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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