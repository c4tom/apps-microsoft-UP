using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendasConsole.Models
{
    class Cliente
    {
        #region C#
        //Construtor
        public Cliente(string cpf)
        {
            CriadoEm = DateTime.Now;
            Cpf = cpf;
        }
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos ou propriedades 
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString()
        {
            return "Nome: " + Nome + " | CPF: " + Cpf;
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = (Cliente) obj;
            if(cliente.Nome.Equals(Nome) &&
                cliente.Cpf.Equals(Cpf))
            {
                return true;
            }
            return false;
        }

        #endregion

        #region JAVA
        //private string nome;
        //private string cpf;
        //public string getNome()
        //{
        //    return nome;
        //}
        //public void setNome(string nome)
        //{
        //    this.nome = nome;
        //} 
        #endregion
    }
}
