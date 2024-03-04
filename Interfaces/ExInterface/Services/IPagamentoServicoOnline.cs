namespace ExInterface.Services
{
    interface IPagamentoServicoOnline
    {
        double TaxaPagamento(double taxaPagamento);
        double Juros(double taxaPagamento, int meses);
    }
}
