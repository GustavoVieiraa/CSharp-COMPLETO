using System;
using System.Linq;

/*              LINQ - Language Integrated Query            
 

    É um conjunto de tecnologias baseadas na integração de
    funcionalidades de consulta diretamente na linguagem C#

        - Operações chamadas diretamente a partir das coleções
        - Consultas são objetos de primeira classe
        - Suporte do compilador e IntelliSense da IDE

    Namespace: System.Linq

    Possui diversas operações de consulta, cujos parâmetros
    tipicamente são expressões lambda ou expressões de sintaxe
    similar à SQL.
 
 
 */


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            // Specify our the data source
            int[] dbNumbers = new int[] { 2, 3, 4, 5, 6, 7, 8 };

            // Define the query expression
            IEnumerable<int> result = dbNumbers
                .Where(num => num % 2 == 0)
                .Select(num => num * 10);

            // Execute the query
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }

        }
    }
}