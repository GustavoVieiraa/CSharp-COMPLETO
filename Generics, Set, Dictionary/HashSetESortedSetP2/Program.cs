using System;
using System.Collections.Generic;

/*
            ### HashSet<T> e SortedSet<T>
    ~ Representa um conjunto de elementos (similar ao da Álgebra)
        - Não admite repetições
        - Elementos não possuem posiçao
        - Acesso, inserção e remoção de elementos são rápidos
        - Oferece operações eficientes de conjunto: interseção, união, diferença.
 

            ### Diferenças
    ~ HashSet
        - Armazenamento em tabela hash
        - Extremamente rápido: inserção, remoção e busca O(1)
        - A ordem dos elementos não é garantida

    ~ SortedSet
        - Armazenamento em árvore
        - Rápido: inserção, remoção e busca O(log(n))
        - Os elementos são armazenados ordenadamente conforme implementação
        IComparer<T>
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedSet<int> sorted = new SortedSet<int>() {0, 2, 6, 10, 22, 35 };
            SortedSet<int> sortedTwo = new SortedSet<int>() { 22, 10, 9, 12, 23, 4 };

            // union
            SortedSet<int> sortedSome = new SortedSet<int>(sorted);
            sortedSome.UnionWith(sortedTwo);
            PrintCollection(sortedSome);
            
            // intersection
            SortedSet<int> d = new SortedSet<int>(sorted);
            d.IntersectWith(sortedTwo);
            PrintCollection(d);

            // difference
            SortedSet<int> e = new SortedSet<int>(sorted);
            e.ExceptWith(sortedTwo);
            PrintCollection(e);
        }


        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}