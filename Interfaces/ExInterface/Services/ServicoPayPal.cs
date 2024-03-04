namespace ExInterface.Services
{
    internal class ServicoPayPal : IPagamentoServicoOnline
    {

        private const double PorcentagemJuros = 0.02;
        private const double JurosMensais = 0.01;

        public double Juros(double taxaPagamento, int meses)
        {
            return taxaPagamento * JurosMensais * meses;
        }

        public double TaxaPagamento(double taxaPagamento)
        {
            return taxaPagamento * PorcentagemJuros; 
        }

        

    }
}
