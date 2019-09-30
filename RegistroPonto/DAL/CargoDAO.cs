﻿using RegistroPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPonto.DAL
{
    class CargoDAO
    {
        private static Context ctx = new Context();

        public static bool Cadastrar(Cargo c)
        {
            //Verifica se existe um registro
            if(BuscarPorNome(c) == null)
            {
                ctx.Cargos.Add(c);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public static Cargo BuscarPorNome(Cargo c)
        {
            return ctx.Cargos.FirstOrDefault(x => x.Nome.Equals(c.Nome));
        }

        public static List<Cargo> Listar()
        {
            return ctx.Cargos.ToList();
        }

        public static Cargo BuscaPorId(int id)
        {
            return ctx.Cargos.Find(id);
        }
    }
}