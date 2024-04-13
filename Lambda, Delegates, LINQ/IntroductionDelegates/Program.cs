using System;
using IntroductionDelegates.Services;

/*
    
                Introdução Delegates

    É uma referência (com type safety) para um ou mais métodos
        É um tipo referência

    Usos comuns:
        Comunicação entre objetos de forma flexível e extensível (eventos / callbacks)
        Parametrização de operações por métodos (programação funcional)
 
 */


namespace Course
{

    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 25;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Max;

            double result = op(a, b);
            Console.WriteLine(result);


        }
    }
}