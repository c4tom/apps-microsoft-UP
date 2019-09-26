using System.Collections.Generic;

using RegistroPonto.Modelo.Entidades;

namespace RegistroPonto.Modelo.Listas
{
  public static class ListasGlobais
  {
    private static List<Cargo> cargos;

    static ListasGlobais()
    {
      cargos = new List<Cargo>();
    }

    public static List<Cargo> Grupos
    {
      get { return cargos; }
    }
  }
}