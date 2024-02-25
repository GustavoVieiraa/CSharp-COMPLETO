using System.Globalization;

namespace ExImpostoContribuintes.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios)
            : base (nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoRenda()
        {
            if (NumeroFuncionarios <= 10)
            {
                Imposto += ((RendaAnual * 16) / 100);
            }
            else
            {
                Imposto += ((RendaAnual * 14) / 100);
            }
            return Imposto;
        }

        public override string DescricaoPagamento()
        {
            return Nome
                + " - R$"
                + ImpostoRenda().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
