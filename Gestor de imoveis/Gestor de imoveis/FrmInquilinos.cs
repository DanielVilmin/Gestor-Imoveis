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
    public partial class FrmInquilinos : Form
    {
        private List<Inquilino> listaInquilinos;
        public FrmInquilinos(List<Inquilino> inquilinos)
        {
            InitializeComponent();
            listaInquilinos = inquilinos;
            CarregarInquilinos();
        }
        private void CarregarInquilinos()
        {
            foreach (var inquilino in listaInquilinos)
            {
                listBoxInquilinos.Items.Add($"ID: {inquilino.IDInquilino} - Nome: {inquilino.Nome}");
            }
        }
        private void FrmInquilinos_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (listBoxInquilinos.SelectedIndex != -1)
            {
                // Obter o inquilino selecionado
                var inquilinoSelecionado = listaInquilinos[listBoxInquilinos.SelectedIndex];

                // Abrir o próximo formulário com os imóveis disponíveis para este inquilino
                FrmImovelInquilino frmImovelInquilino = new FrmImovelInquilino(inquilinoSelecionado);
                frmImovelInquilino.Show();
            }
            else
            {
                MessageBox.Show("Selecione um inquilino.");
            }
        }
    }
}
