using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.Models
{
    [Table("Ponto")]
    class Ponto
    {
        [Key]
        public int PontoId { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Tipo { get; set; }
    }

}
