using MulticastDelegates.Services;
using System;


/*
                          Multicast Delegates

        Delegates que guardam a referência para mais de um método
        
        Para adicionar uma referência, pode-se usar o operador +=

        A chamada Invoke (ou sintaxe reduzida) executa todos os métodos
        na ordem em que foram adicionados.

        Seu uso faz sentido para métodos void

 */


namespace Course
{

    delegate void BinaryNumericoOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 18;
            double b = 25;

            BinaryNumericoOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);

        }
    }
}