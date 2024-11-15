using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Recibo
    {
        private int IdRecibo { get; set; }
        private DateTime DataEmissao { get;  set; }
        private double ValorPago { get; set; }
        private DateTime PeriodoInicio { get; set; }
        private DateTime PeriodoFim { get;  set; }
        private bool Pago { get; set; }
        private Contrato ContratoRelacionado { get; set; }

        public Recibo(int idRecibo, double valorPago, DateTime periodoInicio, DateTime periodoFim, Contrato contrato)
        {
            IdRecibo = idRecibo;
            DataEmissao = DateTime.Now;
            ValorPago = valorPago;
            PeriodoInicio = periodoInicio;
            PeriodoFim = periodoFim;
            ContratoRelacionado = contrato;
            Pago = false;
        }

        public void MarcarComoPago()
        {
            Pago = true;

        }
    }
}
