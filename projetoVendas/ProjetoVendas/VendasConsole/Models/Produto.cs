using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Produto
    {
        #region C#
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos ou propriedades 
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return "Nome: " + Nome + " | Quantidade: " + Quantidade + " | Preço: " + Preco.ToString("C2");
        }
        #endregion

    }
}
