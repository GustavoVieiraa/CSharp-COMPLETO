using System;
using ExInterface.Entities;

namespace ExInterface.Services
{
    internal class ContratoServico
    {
        private IPagamentoServicoOnline _PagamentoServicoOnline;

        public ContratoServico(IPagamentoServicoOnline pagamentoServicoOnline)
        {
            _PagamentoServicoOnline = pagamentoServicoOnline;
        }

        public void ProcessoContrato(Contrato contrato, int meses)
        {
            double quotaBasica = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                
                double atualizacaoQuota = quotaBasica + _PagamentoServicoOnline.Juros(quotaBasica, i);
                double QuotaTotal = atualizacaoQuota + _PagamentoServicoOnline.TaxaPagamento(atualizacaoQuota);

                contrato.AddParcela(new Parcela(data, QuotaTotal));
            }
        }
    }
}
