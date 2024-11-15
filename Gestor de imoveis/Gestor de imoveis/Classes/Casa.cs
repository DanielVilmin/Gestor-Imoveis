using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Casa : Imovel
    {
        private int Andares { get; set; }
        private int Quartos { get; set; }
        private double Area { get; set; }
        private string Extras { get; set; }

        public Casa(int IdCasa, string distrito, string concelho, string endereco, double preco, bool disponivel, int andares, int quartos, double area, string extras)
            : base(IdCasa, distrito, concelho, endereco, preco, disponivel)
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
    }
}
