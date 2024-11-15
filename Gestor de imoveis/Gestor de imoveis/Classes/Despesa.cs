using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Despesa
    {
        private string Descricao { get; set; }
        private DateTime DataSolicitacao { get; set; }
        private bool Resolvido { get; set; }

        public Despesa(string descricao)
        {
            Descricao = descricao;
            DataSolicitacao = DateTime.Now;
            Resolvido = false;
        }

        public void MarcarComoResolvido()
        {
            Resolvido = true;
        }
    }
}
