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

            HashSet<string> set = new HashSet<string>();

            set.Add("Gusta");
            set.Add("Porsche");
            set.Add("Iphone");

            foreach (string item in set)
            {
                Console.WriteLine(item);
            }

        }
    }
}