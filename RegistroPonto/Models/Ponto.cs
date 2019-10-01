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
        public DateTime DataRegistro { get; set; }
        public TipoEntradaSaida Tipo { get; set; } = new TipoEntradaSaida();
        public Usuario Usuario { get; set; } = new Usuario();

        public Ponto()
        {

        }
        public Ponto(int pontoId, DateTime dataRegistro, TipoEntradaSaida tipo, Usuario usuario)
        {
            PontoId = pontoId;
            DataRegistro = dataRegistro;
            Tipo = tipo;
            Usuario = usuario;
        }
    }

}
