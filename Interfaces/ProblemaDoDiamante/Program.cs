using ProblemaDoDiamante.Devices;
using System;
using System.Globalization;

/*
        ### Problema do Diamante
    A herança múltipla pode gerar o problema do
    diamante: uma ambiguidade causada pela
    existência do mesmo método em mais de uma
    superclasse.
    
    Herança múltipla não é permitida na maioria
    das linguagens!
 
 */

namespace Device
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 2050};
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner() { SerialNumber = 2005};
            s.ProcessDoc("My hotdogs");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3210};
            c.ProcessDoc("My testing topzera");
            c.Print("My testing ok");
            Console.WriteLine(c.Scan());
        }
    }
}