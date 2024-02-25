namespace ExImpostoContribuintes.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public double Imposto { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostoRenda();

        public abstract string DescricaoPagamento();
        
    }
}
