using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Inquilino : Pessoa
    {
        private int IDInquilino { get; set; }
        private int NumContrato { get; set; }
        public DocumentosInquilino Documentos { get; set; }

        public Inquilino(int idInq, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso, int numcontrato)
            : base(idInq, nome, datanascimento, telefone, email, nif, nomeconta, pass, acesso)
        {
            IDInquilino = idInq;
            NumContrato = numcontrato;
        }

        public void RegistrarDocumentos(string fotoBI, List<string> comprovativosVencimento, string registoCriminal)
        {
            if (Documentos == null)
            {
                Documentos = new DocumentosInquilino(fotoBI, comprovativosVencimento, registoCriminal);
            }
        }

    }
}
