using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    /*public class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public int NIF { get; set; }
        public string NomeConta { get; set; }
        public string Pass { get; set; }
        public bool Acesso { get; set; }

        public Pessoa (int id, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso)
        {
            ID = id;
            Nome = nome;
            DataNascimento = datanascimento;
            Telefone = telefone;
            Email = email;
            NIF = nif;
            NomeConta = nomeconta;
            Pass = pass;
            Acesso = acesso;
        }
 }
*/

    /* public class Proprietario : Pessoa
     {
         public int QntImoveis { get; set; }
         public List<Imovel> Imoveis { get; set; }
         public Proprietario(int idProp, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso, int qntimoveis)
             :base(idProp,nome,datanascimento,telefone,email,nif,nomeconta,pass,acesso)
         {
             QntImoveis = qntimoveis;
             Imoveis = new List<Imovel>();
         }

         public void AtribuirImovel(Imovel imovel)
         {
             Imoveis.Add(imovel);
             QntImoveis++; // Atualizando a quantidade de imóveis do proprietário
             Console.WriteLine($"Imóvel {imovel.IDImovel} atribuído ao proprietário {Nome}. Quantidade total de imóveis: {QntImoveis}");
         }
    } */

   /* public class Inquilino : Pessoa
    {
        public int NumContrato { get; set; }
        public DocumentosInquilino Documentos { get; set; }

        public Inquilino(int idInq, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso, int numcontrato)
            : base(idInq, nome, datanascimento, telefone, email, nif, nomeconta, pass, acesso)
        {
            NumContrato = numcontrato;
        }

        public void RegistrarDocumentos(string fotoBI, List<string> comprovantesVencimento, string registoCriminal)
        {
            // Se não tiver documentos registrados, registra novos documentos
            if (Documentos == null)
            {
                Documentos = new DocumentosInquilino(fotoBI, comprovantesVencimento, registoCriminal);
                Console.WriteLine($"Documentos registrados com sucesso para {Nome}");
            }
            else
            {
                // Caso os documentos já existam, pode-se atualizar ou informar o usuário
                Console.WriteLine($"Os documentos já foram registrados para {Nome}");
            }
        }

    }
*/

   /* public class DocumentosInquilino
    {
        public string FotoBI { get; set; } // Caminho ou URL da foto do BI
        public List<string> ComprovativoVencimento { get; set; } // Lista com os caminhos ou URLs dos 3 últimos comprovantes de vencimento
        public string RegistoCriminal { get; set; } // Caminho ou URL do registo criminal

        public DocumentosInquilino(string fotoBI, List<string> comprovativoVencimento, string registoCriminal)
        {
            FotoBI = fotoBI;
            ComprovativoVencimento = comprovativoVencimento;
            RegistoCriminal = registoCriminal;
        }

    }*/

   /* public abstract class Imovel
    {
        public int IDImovel { get; set; }
        public string Distrito { get; set; }
        public string Concelho { get; set; }
        public string Endereco { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }
        public List<Contrato> Contratos { get; private set; } = new List<Contrato>();
        public Proprietario Proprietario { get; set; }

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

            Disponivel = false;  // Marcar o imóvel como indisponível após o aluguel
            return novoContrato;
        }
        public void AtribuirProprietario(Proprietario proprietario)
        {
            Proprietario = proprietario;
            Console.WriteLine($"Imóvel {IDImovel} atribuído ao proprietário {proprietario.Nome}");
        }
    }*/

   /* public class Casa : Imovel
    {
        public int Andares { get; set; }
        public int Quartos { get; set; }
        public double Area { get; set; }
        public string Extras { get; set; }

        public Casa(int IdCasa, string distrito, string concelho, string endereco, double preco, bool disponivel, int andares, int quartos,double area,string extras)
            :base(IdCasa,distrito,concelho,endereco,preco,disponivel)
        {
            Andares = andares;
            Quartos = quartos;
            Area = area;
            Extras = extras;
        }
        public override string ObterEspecificacoes()
        {
            return $"Casa com {Andares} andares, {Quartos} quartos, {Area} m², Extras: {Extras}";
        }
    }*/

    /*public class Apartamento : Imovel
    {
        public int Piso { get; set; }
        public int Andares { get; set; }
        public int Quartos { get; set; }
        public double Area { get; set; }
        public string Extras { get; set; }
        public Apartamento(int IdApartamento, string distrito, string concelho, string endereco, double preco, bool disponivel,int piso, int andares, int quartos, double area, string extras)
            : base(IdApartamento, distrito, concelho, endereco, preco, disponivel)
        {
            Piso = piso;
            Andares = andares;
            Quartos = quartos;
            Area = area;
            Extras = extras;
        }
        public override string ObterEspecificacoes()
        {
            return $"Apartamento no {Piso}º piso, {Quartos} quartos, {Area} m², Extras: {Extras}";
        }
    }*/

   /* public class Terreno : Imovel
    {
        public double Area {get; set;}
        bool PremissaoConstrucao { get; set; }
        public Terreno(int IdTerreno, string distrito, string concelho, string endereco, double preco, bool disponivel, double area, bool permissaocontrucao)
            : base(IdTerreno, distrito, concelho, endereco, preco, disponivel)
        {
            Area = area;
            PremissaoConstrucao = permissaocontrucao;
        }
        public override string ObterEspecificacoes()
        {
            return $"Terreno com área de {Area} m², Permissão para construção: {(PremissaoConstrucao ? "Sim" : "Não")}";
        }
    }*/

    /*public class Contrato
    {
        public Proprietario Proprietario { get; private set; }
        public Inquilino Inquilino { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public double Renda { get; private set; }
        public Imovel ImovelAlugado { get; private set; }
        public string EspecificacoesImovel { get; private set; }
        public List<Despesa> Despesas { get; private set; } = new List<Despesa>();
        public List<Recibo> Recibos { get; private set; } = new List<Recibo>();

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

            NotificarProprietario(novaDespesa);
        }
        private void NotificarProprietario(Despesa despesa)
        {
            // Aqui, exibir uma notificação simulada, ou enviar um e-mail (se for um sistema real)
            Console.WriteLine($"Notificação para {Proprietario.Nome}: Nova solicitação de reparo: {despesa.Descricao}, registrada em {despesa.DataSolicitacao.ToShortDateString()}.");
        }

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
            Console.WriteLine($"Recibo para o mês {mes}/{ano} gerado com valor de {Renda}.");
        }
        public void MarcarReciboComoPago(int idRecibo)
        {
            Recibo recibo = Recibos.FirstOrDefault(r => r.IdRecibo == idRecibo);
            if (recibo != null)
            {
                recibo.MarcarComoPago();
            }
            else
            {
                Console.WriteLine($"Recibo com ID {idRecibo} não encontrado.");
            }
        }

        public void ListarRecibos()
        {
            Console.WriteLine($"Recibos do contrato para o imóvel: {ImovelAlugado.IDImovel}");
            foreach (var recibo in Recibos)
            {
                string status = recibo.Pago ? "Pago" : "Pendente";
                Console.WriteLine($"Recibo ID: {recibo.IdRecibo}, Valor: {recibo.ValorPago}, Período: {recibo.PeriodoInicio.ToShortDateString()} - {recibo.PeriodoFim.ToShortDateString()}, Status: {status}");
            }
        }

    }*/


    /*public class Despesa
    {
        public string Descricao { get; private set; }
        public DateTime DataSolicitacao { get; private set; }
        public bool Resolvido { get; private set; }

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
    }*/

   /* public class Recibo
    {
        public int IdRecibo { get; private set; }
        public DateTime DataEmissao { get; private set; }
        public double ValorPago { get; private set; }
        public DateTime PeriodoInicio { get; private set; }
        public DateTime PeriodoFim { get; private set; }
        public bool Pago { get; private set; }
        public Contrato ContratoRelacionado { get; private set; }

        public Recibo(int idRecibo, double valorPago, DateTime periodoInicio, DateTime periodoFim, Contrato contrato)
        {
            IdRecibo = idRecibo;
            DataEmissao = DateTime.Now;
            ValorPago = valorPago;
            PeriodoInicio = periodoInicio;
            PeriodoFim = periodoFim;
            ContratoRelacionado = contrato;
            Pago = false; // Inicialmente o recibo é criado como não pago
        }

        public void MarcarComoPago()
        {
            Pago = true;
            Console.WriteLine($"Recibo {IdRecibo} marcado como pago.");
        }
    }*/

}
