using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public abstract class Imovel
    {
        private int IDImovel { get; set; }
        private string Distrito { get; set; }
        private string Concelho { get; set; }
        private string Endereco { get; set; }
        private double Preco { get; set; }
        private bool Disponivel { get; set; }
        private List<Contrato> Contratos { get;  set; } = new List<Contrato>();
        private Proprietario Proprietario { get; set; }

        public Imovel(int idimovel, string distrito, string concelho, string endereco, double preco, bool disponivel)
        {
            IDImovel = idimovel;
            Distrito = distrito;
            Concelho = concelho;
            Endereco = endereco;
            Preco = preco;
            Disponivel = disponivel;


        }

        public abstract string ObterEspecificacoes();

        public Contrato RealizarContrato(Proprietario proprietario, Inquilino inquilino, DateTime dataInicio, DateTime dataFim, double renda)
        {
            if (!Disponivel)
            {
                throw new InvalidOperationException("Imóvel não está disponível para alugar.");
            }

            if (dataInicio >= dataFim)
            {
                throw new ArgumentException("A data de início deve ser anterior à data de fim.");
            }

            Contrato novoContrato = new Contrato(proprietario, inquilino, dataInicio, dataFim, renda, this);
            Contratos.Add(novoContrato);

            Disponivel = false;  
            return novoContrato;
        }
        public void AtribuirProprietario(Proprietario proprietario)
        {
            Proprietario = proprietario;
        }
    }
}
