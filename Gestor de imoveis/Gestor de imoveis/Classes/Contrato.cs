using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Contrato
    {
        private Proprietario Proprietario { get;  set; }
        private Inquilino Inquilino { get;  set; }
        private DateTime DataInicio { get; set; }
        private DateTime DataFim { get;  set; }
        private double Renda { get;  set; }
        private Imovel ImovelAlugado { get; set; }
        private string EspecificacoesImovel { get;  set; }
        private List<Despesa> Despesas { get;  set; } = new List<Despesa>();
        private List<Recibo> Recibos { get;  set; } = new List<Recibo>();

        public Contrato(Proprietario proprietario, Inquilino inquilino, DateTime dataInicio, DateTime dataFim, double renda, Imovel imovelAlugado)
        {
            Proprietario = proprietario;
            Inquilino = inquilino;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Renda = renda;
            ImovelAlugado = imovelAlugado;
            EspecificacoesImovel = imovelAlugado.ObterEspecificacoes();
        }

        public void RegistrarDespesa(string descricao)
        {
            Despesa novaDespesa = new Despesa(descricao);
            Despesas.Add(novaDespesa);

           // NotificarProprietario(novaDespesa);
        }
       /* private void NotificarProprietario(Despesa despesa)
        {
            Console.WriteLine($"Notificação para {Proprietario.Nome}: Nova solicitação de reparo: {despesa.Descricao}, registrada em {despesa.DataSolicitacao.ToShortDateString()}.");
        }*/
        public bool IsContratoAtivo()
        {
            return DateTime.Now >= DataInicio && DateTime.Now <= DataFim;
        }
        public void GerarReciboMensal(int mes, int ano)
        {
            DateTime periodoInicio = new DateTime(ano, mes, 1);
            DateTime periodoFim = periodoInicio.AddMonths(1).AddDays(-1); // Último dia do mês
            Recibo novoRecibo = new Recibo(Recibos.Count + 1, Renda, periodoInicio, periodoFim, this);
            Recibos.Add(novoRecibo);
        }
        public void MarcarReciboComoPago(int idRecibo)
        {
            Recibo recibo = Recibos.FirstOrDefault(r => r.IdRecibo == idRecibo);
            if (recibo != null)
            {
                recibo.MarcarComoPago();
            }       
        }
        public void ListarRecibos()
        {
            foreach (var recibo in Recibos)
            {
                string status = recibo.Pago ? "Pago" : "Pendente";
                Console.WriteLine($"Recibo ID: {recibo.IdRecibo}, Valor: {recibo.ValorPago}, Período: {recibo.PeriodoInicio.ToShortDateString()} - {recibo.PeriodoFim.ToShortDateString()}, Status: {status}");
            }
        }

    }
}
