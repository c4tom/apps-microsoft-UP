using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPonto.Models
{
    [Table("Cago")]
    class Cargo
    {
        public Cargo()
        {

        }
        [Key]        public int CargoId { get; set; }        public string Nome { get; set; }        public double Salario { get; set; }
    }
}
