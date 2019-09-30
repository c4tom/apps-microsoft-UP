using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPonto.Models
{
    [Table("Cargo")]
    class Cargo
    {
        public Cargo()
        {

        }

        [Key]
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

    }
}
