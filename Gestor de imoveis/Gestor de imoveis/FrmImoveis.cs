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
    public partial class FrmImoveis : Form
    {
        private List<Imovel> listaImoveis;
        private Proprietario proprietarioSelecionado;
        public FrmImoveis(List<Imovel> imoveis, Proprietario proprietario)
        {
            InitializeComponent();
            listaImoveis = imoveis;
            proprietarioSelecionado = proprietario;

            // Popular a lista de imóveis disponíveis
            foreach (var imovel in listaImoveis)
            {
                if (imovel.Proprietario == null) // Apenas imóveis sem proprietário
                {
                    listBoxImoveis.Items.Add($"ID: {imovel.IDImovel} - {imovel.ObterEspecificacoes()}");
                }
            }
        }

        private void FrmImoveis_Load(object sender, EventArgs e)
        {

        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            // Verificar se um imóvel foi selecionado
            if (listBoxImoveis.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um imóvel.");
                return;
            }

            // Obter o imóvel selecionado
            Imovel imovelSelecionado = listaImoveis[listBoxImoveis.SelectedIndex];

            // Atribuir o proprietário ao imóvel
            imovelSelecionado.AtribuirProprietario(proprietarioSelecionado);

            // Mostrar mensagem de sucesso
            MessageBox.Show($"Imóvel {imovelSelecionado.IDImovel} atribuído ao proprietário {proprietarioSelecionado.Nome}.", "Atribuição Concluída");

            // Fechar o formulário
            this.Close();
        }
    }
}
