using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {
        private VendedorDAO() { }

        private static List<Vendedor> vendedores = new List<Vendedor>();
        public static bool CadastrarVendedor(Vendedor v)
        {
            if (BuscarVendedorPorCpf(v) != null)
            {
                return false;
            }
            vendedores.Add(v);
            return true;
        }

        public static Vendedor BuscarVendedorPorCpf(Vendedor v)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf.Equals(v.Cpf))
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }
        public static List<Vendedor> ListarVendedores()
        {
            return vendedores;
        }
    }
}
