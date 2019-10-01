using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPonto.Models
{
    [Table("Usuario")]
    class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Registro { get; set; }
        public DateTime DataNascimento { get; set; }
        public Cargo Cargo { get; set; }

        public Usuario()
        {

        }

        public Usuario(int usuarioId, string nome, string registro, DateTime dataNascimento, Cargo cargo)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Registro = registro;
            DataNascimento = dataNascimento;
            Cargo = cargo;
        }
    }



}
