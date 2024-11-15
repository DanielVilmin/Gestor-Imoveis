using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Apartamento : Imovel
    {
        private int Piso { get; set; }
        private int Andares { get; set; }
        private int Quartos { get; set; }
        private double Area { get; set; }
        private string Extras { get; set; }
        public Apartamento(int IdApartamento, string distrito, string concelho, string endereco, double preco, bool disponivel, int piso, int andares, int quartos, double area, string extras)
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
    }
}
