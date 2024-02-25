using System.Globalization;

namespace ExImpostoContribuintes.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude)
            : base (nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoRenda()
        {
            if (RendaAnual < 20000)
            {
                Imposto += ((RendaAnual * 15) / 100);
            }
            if (RendaAnual >= 20000)
            {
                Imposto += ((RendaAnual * 25) / 100);
            }
            if (GastosSaude > 0)
            {
                Imposto -= ((GastosSaude * 50) / 100);
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
