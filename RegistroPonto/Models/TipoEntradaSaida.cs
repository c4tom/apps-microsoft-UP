using System.ComponentModel.DataAnnotations;

namespace RegistroPonto.Models
{
    class TipoEntradaSaida
    {
        [Key]
        public int TipoId { get; set; }
        public string Tipo { get; set; }
        public TipoEntradaSaida() { }

        public TipoEntradaSaida(int id, string tipo)
        {
            TipoId = id;
            Tipo = tipo;
        }
    }
}
