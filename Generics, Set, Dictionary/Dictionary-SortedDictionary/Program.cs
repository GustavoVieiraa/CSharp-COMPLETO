using System;

/*
                ### Dictionary <TKey, TValue>
    É uma coleção de pares chave / valor
        ~ Não admite repetições do objeto chave
        ~ Os elementos são indexados pelo objeto chave (não possuem posição)
        ~ Acesso, inserção e remoção de elementos são rápidos

    Uso comum: cookies, local storage, qualquer modelo chave-valor
 
                ### Diferenças
    Dictionary
        ~ Armazenamento em tabela hash
        ~ Extremamente rápido: inserção, remoção e busca O(1)
        ~ A ordem dos elementos não é garantida

    SortedDictionary
        ~ Armazenamento em árvore
        ~ Rápido: inserção, remoção e busca O(log(n))
        ~ Os elementos são armazenados ordenadamente conforme
        implementação IComparer<T>
 */

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Dictionary<string, string> cookies = new Dictionary<string, string>();

                cookies["user"] = "gustago";
                cookies["email"] = "gustago@gmail.com";
                cookies["phone"] = "99999-9999";
                cookies["phone"] = "98989-9888";

                Console.WriteLine(cookies["email"]);
                Console.WriteLine(cookies["phone"]);


                if (cookies.ContainsKey("email"))
                {
                    Console.WriteLine(cookies["email"]);
                }
                else
                {
                    throw new Exception("Error: Cookie [email] not found");
                }

                Console.WriteLine($"Size dictionary: {cookies.Count}");

                Console.WriteLine("ALL COOKIES: ");

                foreach (KeyValuePair<string, string> cookie in cookies)
                {
                    Console.WriteLine($"{cookie.Key} - {cookie.Value}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

        } 
    }
}