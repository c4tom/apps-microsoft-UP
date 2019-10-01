using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPonto.Models
{
    [Table("Cargo")]
    class Cargo
    {
        [Key]
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Cargo()
        {

        }

        public Cargo(int cargoId, string nome, double salario)
        {
            CargoId = cargoId;
            Nome = nome;
            Salario = salario;
        }
    }
}
