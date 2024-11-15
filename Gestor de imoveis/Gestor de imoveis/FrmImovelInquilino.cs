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
    public partial class FrmImovelInquilino : Form
    {
        private Inquilino inquilinoSelecionado;
        private List<Imovel> listaImoveis;
        public FrmImovelInquilino(Inquilino inquilino)
        {
            InitializeComponent();
            inquilinoSelecionado = inquilino;
            listaImoveis = new List<Imovel>()
        {
            new Casa(1, "Lisboa", "Lisboa", "Rua A", 1000, true, 2, 3, 150, "Garagem"),
            new Terreno(3, "Algarve", "Faro", "Rua C", 50000, true, 2000, true)
        };
            CarregarImoveis();
        }
        private void CarregarImoveis()
        {
            // Filtra imóveis que têm um proprietário atribuído
            var imoveisComProprietario = listaImoveis.Where(i => i.Proprietario != null).ToList();

            foreach (var imovel in imoveisComProprietario)
            {
                listBoxImoveis.Items.Add($"ID: {imovel.IDImovel} - {imovel.ObterEspecificacoes()} - Proprietário: {imovel.Proprietario.Nome}");
            }
        }
        private void FrmImovelInquilino_Load(object sender, EventArgs e)
        {

        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            if (listBoxImoveis.SelectedIndex != -1)
            {
                var imovelSelecionado = listaImoveis[listBoxImoveis.SelectedIndex];

                // Vamos criar um contrato fictício entre o inquilino e o proprietário
                DateTime dataInicio = DateTime.Now;
                DateTime dataFim = dataInicio.AddMonths(12); // Um ano de contrato
                double renda = imovelSelecionado.Preco;

                // Criando contrato fictício
                try
                {
                    Contrato contrato = imovelSelecionado.RealizarContrato(imovelSelecionado.Proprietario, inquilinoSelecionado, dataInicio, dataFim, renda);
                    MessageBox.Show($"Contrato realizado com sucesso! \nProprietário: {imovelSelecionado.Proprietario.Nome} \nInquilino: {inquilinoSelecionado.Nome} \nImóvel: {imovelSelecionado.ObterEspecificacoes()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao realizar contrato: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um imóvel.");
            }
        }
    }
    
}
