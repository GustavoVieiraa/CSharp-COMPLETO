using System;
using System.IO;

/*
            ### Directory, DirectoryInfo

    - Namespace System.IO
    
    - Operações com pastas (create, enumerate, get files, etc.).
    
    - Directory
        ~ Static Members (simple, but performs security check for each operation)
    
    - DirectoryInfo
        ~ Instance members
 */

namespace CourseFile
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\temp\myfolder";

            try
            {
                // IEnumerable<string> - Listagem de Pastas
                var folders = Directory.EnumerateDirectories(file, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (string f in folders)
                {
                    Console.WriteLine(f);
                }

                // Listagem de arquivos em uma pasta
                var files = Directory.EnumerateFiles(file, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }

                Directory.CreateDirectory(file + @"\newFolder");

            }
            catch (IOException e)
            {
                Console.WriteLine($"Error: {e}");
            }

        }
    }
}