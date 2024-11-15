using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class DocumentosInquilino
    {
        private string FotoBI { get; set; } 
        private List<string> ComprovativoVencimento { get; set; } 
        private string RegistoCriminal { get; set; }

        public DocumentosInquilino(string fotoBI, List<string> comprovativoVencimento, string registoCriminal)
        {
            FotoBI = fotoBI;
            ComprovativoVencimento = comprovativoVencimento;
            RegistoCriminal = registoCriminal;
        }

    }
}
