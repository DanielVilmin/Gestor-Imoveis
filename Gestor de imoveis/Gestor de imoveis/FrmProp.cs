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
    public partial class FrmProp : Form
    {
        private List<Proprietario> listaProprietarios;
        private List<Imovel> listaImoveis;
        private Proprietario proprietarioSelecionado;


        public FrmProp(List<Proprietario> proprietarios, List<Imovel> imoveis)
        {
            InitializeComponent();
            listaProprietarios = proprietarios;
            listaImoveis = imoveis;
            foreach (var proprietario in listaProprietarios)
            {
                listBoxProprietarios.Items.Add($"ID: {proprietario.IDProprietario}  - Nome: {proprietario.Nome}");
            }
        }

        private void FrmProp_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            // Verificar se um proprietário foi selecionado
            if (listBoxProprietarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um proprietário.");
                return;
            }

            // Obter o proprietário selecionado
            proprietarioSelecionado = listaProprietarios[listBoxProprietarios.SelectedIndex];

            // Abrir o formulário FrmImoveis
            FrmImoveis frmImoveis = new FrmImoveis(listaImoveis, proprietarioSelecionado);
            frmImoveis.ShowDialog();

            // Fechar este formulário após a seleção
            this.Close();
        }
    }
}
