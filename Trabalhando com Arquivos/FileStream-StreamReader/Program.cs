using System;
using System.IO;

namespace CourseFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\test\file1.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(file);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

        }
    }
}