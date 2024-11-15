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

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private List<Pessoa> pessoas = new List<Pessoa>();
        private void BtnPessoa_Click(object sender, EventArgs e)
        {
            Proprietario proprietario = new Proprietario(1, "João Silva", new DateTime(1980, 5, 20), 123456789, "joao@email.com", 123456789, "joaosilva", "senha123", true, 2);
            pessoas.Add(proprietario);
            MessageBox.Show($"Utilizador {proprietario.NomeConta} foi adicionado com sucesso!");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string nomeConta = txtLogin.Text;
            string senha = txtPass.Text;

            // Procurar a pessoa na lista
            Pessoa pessoaEncontrada = pessoas.FirstOrDefault(p => p.NomeConta == nomeConta && p.Pass == senha);

            if (pessoaEncontrada != null)
            {
                // Login bem-sucedido
                MessageBox.Show($"Bem-vindo, {pessoaEncontrada.Nome}!");
                // Abrir o Form1
                frmInicial form1 = new frmInicial();
                form1.Show();

                // Fechar o FrmLogin
                this.Hide();
            }
            else
            {
                // Login falhou
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
