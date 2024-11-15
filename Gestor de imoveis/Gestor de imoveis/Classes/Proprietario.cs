using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
        public class Proprietario : Pessoa
        {
        private int IDProprietario { get; set; }
        private int QntImoveis { get; set; }
        private List<Imovel> Imoveis { get; set; }
            public Proprietario(int idProp, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso, int qntimoveis)
                : base(idProp, nome, datanascimento, telefone, email, nif, nomeconta, pass, acesso)
            {
                IDProprietario = idProp;
                QntImoveis = qntimoveis;
                Imoveis = new List<Imovel>();
            }

            public void AtribuirImovel(Imovel imovel)
            {
                Imoveis.Add(imovel);
                QntImoveis++;
            }
        }
    
}
