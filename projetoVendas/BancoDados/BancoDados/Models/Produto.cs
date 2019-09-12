using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados.Models
{
    [Table("Produtos")]
    class Produto
    {
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int ProdutId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
        public Categoria Categoria { get; set; }
        public override string ToString()
        {
            return "Nome: " + Nome + 
                " | Quantidade: " + Quantidade + 
                " | Preço: " + Preco.ToString("C2") + 
                " | Categoria: " + Categoria.Nome;
        }

    }
}
