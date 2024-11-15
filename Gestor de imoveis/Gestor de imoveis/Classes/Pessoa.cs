using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Pessoa
    {
        private int ID { get; set; }
        private string Nome { get; set; }
        private DateTime DataNascimento { get; set; }
        private int Telefone { get; set; }
        private string Email { get; set; }
        private int NIF { get; set; }
        private string NomeConta { get; set; }
        private string Pass { get; set; }
        private bool Acesso { get; set; }

        public Pessoa(int id, string nome, DateTime datanascimento, int telefone, string email, int nif, string nomeconta, string pass, bool acesso)
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
}
