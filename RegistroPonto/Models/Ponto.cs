using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPonto.Models
{
    [Table("Ponto")]
    class Ponto
    {
        [Key]
        public int PontoId { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DataRegistroEntrada { get; set; }
        public DateTime? DataRegistroSaida { get; set; }
        public Usuario Usuario { get; set; } = new Usuario();

        public Ponto()
        {

        }
        public Ponto(int pontoId, DateTime entrada, DateTime saida, Usuario usuario)
        {
            PontoId = pontoId;
            DataRegistroEntrada = entrada;
            DataRegistroSaida = saida;
            Usuario = usuario;
        }

        public Ponto(DateTime? dataRegistroEntrada, DateTime? dataRegistroSaida, Usuario usuario)
        {
            DataRegistroEntrada = dataRegistroEntrada;
            DataRegistroSaida = dataRegistroSaida;
            Usuario = usuario;
        }
    }

}
