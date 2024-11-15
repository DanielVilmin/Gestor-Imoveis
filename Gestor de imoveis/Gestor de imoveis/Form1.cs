using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_imoveis
{
    public partial class frmInicial : Form
    {
        public frmInicial()
        {
            InitializeComponent();
        }

        private List<Proprietario> listaProprietarios = new List<Proprietario>();
        private List<Inquilino> listaInquilinos = new List<Inquilino>();
        private List<Imovel> listaImoveis = new List<Imovel>();


        private void inserirImovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mostrarImoveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCriarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar instâncias de Proprietario e Inquilino
                Proprietario proprietario = new Proprietario(1, "João Silva", new DateTime(1980, 5, 20), 123456789, "joao@email.com", 123456789, "joaosilva", "senha123", true, 2);
                Inquilino inquilino = new Inquilino(2, "Maria Santos", new DateTime(1992, 3, 15), 987654321, "maria@email.com", 987654321, "mariasantos", "senha456", true, 101);

                // Criar um imóvel do tipo Casa
                Casa casa = new Casa(10, "Lisboa", "Centro", "Rua das Flores, 123", 1500, true, 2, 3, 120.5, "Piscina");

                // Realizar o contrato de aluguel para a casa
                Contrato contratoCasa = casa.RealizarContrato(proprietario, inquilino, DateTime.Now, DateTime.Now.AddMonths(12), 1200);

                // Exibir informações do contrato
                MessageBox.Show($"Contrato criado! Imóvel: {contratoCasa.EspecificacoesImovel}\nProprietário: {contratoCasa.Proprietario.Nome}\nInquilino: {contratoCasa.Inquilino.Nome}", "Contrato Criado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar o contrato: {ex.Message}", "Erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criar instâncias de Proprietario, Inquilino e Imovel
            Proprietario proprietario = new Proprietario(1, "João Silva", new DateTime(1980, 5, 20), 123456789, "joao@email.com", 123456789, "joaosilva", "senha123", true, 2);
            Inquilino inquilino = new Inquilino(2, "Maria Santos", new DateTime(1992, 3, 15), 987654321, "maria@email.com", 987654321, "mariasantos", "senha456", true, 101);
            Casa casa = new Casa(10, "Lisboa", "Centro", "Rua das Flores, 123", 1500, true, 2, 3, 120.5, "Piscina");

            // Realizar contrato
            Contrato contratoCasa = casa.RealizarContrato(proprietario, inquilino, DateTime.Now, DateTime.Now.AddMonths(12), 1200);

            // Registrar uma despesa
            contratoCasa.RegistrarDespesa("Tomada da casa de banho da suíte avariada, precisa de um técnico.");

            // Listar todas as despesas
            foreach (var despesa in contratoCasa.Despesas)
            {
                MessageBox.Show("Despesa Registada");
                Console.WriteLine(despesa);
            }
        }

        private void frmInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnProprietario_Click(object sender, EventArgs e)
        {
            Proprietario novoProprietario = new Proprietario(
               idProp: listaProprietarios.Count + 1, // ID incremental
               nome: "RualProp ",
               datanascimento: new DateTime(1970, 1, 1),
               telefone: 900000000,
               email: $"proprietario@email.com",
               nif: 100000000,
               nomeconta: "prop",
               pass: "senha123",
               acesso: true,
               qntimoveis: 0
           );

            listaProprietarios.Add(novoProprietario);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Proprietário '{novoProprietario.Nome}' criado com sucesso!", "Proprietário Criado");
        }

        private void btnInquilino_Click(object sender, EventArgs e)
        {
            // Criar um novo inquilino com dados fictícios
            Inquilino novoInquilino = new Inquilino(
                idInq: listaInquilinos.Count + 1, // ID incremental
                nome: "DanielInq",
                datanascimento: new DateTime(1985, 1, 1),
                telefone: 910000000,
                email: $"inquilino@email.com",
                nif: 200000000,
                nomeconta: "inq",
                pass: "senha456",
                acesso: true,
                numcontrato: 0
            );

            // Adicionar à lista de inquilinos
            listaInquilinos.Add(novoInquilino);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Inquilino '{novoInquilino.Nome}' criado com sucesso!", "Inquilino Criado");
        }

        private void btnCriarCasa_Click(object sender, EventArgs e)
        {
            // Criar uma nova casa com dados fictícios
            Casa novaCasa = new Casa(
                IdCasa: listaImoveis.Count + 1, // ID incremental
                distrito: "Lisboa",
                concelho: "Lisboa",
                endereco: $"Rua das Casas, {listaImoveis.Count + 1}",
                preco: 250000, 
                disponivel: true,
                andares: 2,
                quartos: 3,
                area: 150.5,
                extras: "Garagem, Jardim"
            );

            // Adicionar à lista de imóveis
            listaImoveis.Add(novaCasa);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Casa criada com sucesso! {novaCasa.ObterEspecificacoes()}", "Casa Criada");
        }

        private void btnCriarApartamento_Click(object sender, EventArgs e)
        {
            // Criar um novo apartamento com dados fictícios
            Apartamento novoApartamento = new Apartamento(
                IdApartamento: listaImoveis.Count + 1, // ID incremental
                distrito: "Porto",
                concelho: "Porto",
                endereco: $"Avenida dos Apartamentos, {listaImoveis.Count + 1}",
                preco: 180000, // Preço variável
                disponivel: true,
                piso: 5,
                andares: 10,
                quartos: 2,
                area: 95.0,
                extras: "Varanda, Elevador"
            );

            // Adicionar à lista de imóveis
            listaImoveis.Add(novoApartamento);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Apartamento criado com sucesso! {novoApartamento.ObterEspecificacoes()}", "Apartamento Criado");
        }

        private void btnCriarTerreno_Click(object sender, EventArgs e)
        {
            // Criar um novo terreno com dados fictícios
            Terreno novoTerreno = new Terreno(
                IdTerreno: listaImoveis.Count + 1, // ID incremental
                distrito: "Coimbra",
                concelho: "Coimbra",
                endereco: $"Estrada dos Terrenos, {listaImoveis.Count + 1}",
                preco: 75000, // Preço variável
                disponivel: true,
                area: 2000.0,
                permissaocontrucao: true
            );

            // Adicionar à lista de imóveis
            listaImoveis.Add(novoTerreno);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Terreno criado com sucesso! {novoTerreno.ObterEspecificacoes()}", "Terreno Criado");
        }

        private void btnAtribuirImovelProp_Click(object sender, EventArgs e)
        {
           
            FrmProp frmProp = new FrmProp(listaProprietarios, listaImoveis);
            frmProp.ShowDialog();
        }

        private void btnAtribuirImovelInq_Click(object sender, EventArgs e)
        {
            FrmInquilinos frmInquilinos = new FrmInquilinos(listaInquilinos);
            frmInquilinos.Show();
        }
    }
}
