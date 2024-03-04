namespace ProblemaDoDiamante.Devices
{
     class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Printer {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }
        
    }
}
