using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_de_imoveis
{
    public class Terreno : Imovel
    {
        private double Area { get; set; }
        private bool PremissaoConstrucao { get; set; }
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
    }
}
