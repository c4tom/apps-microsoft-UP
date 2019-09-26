using System;

using RegistroPonto.Modelo.Base;

namespace RegistroPonto.Modelo.Entidades
{
  public class Cargo : BaseIdNome<int>, IComparable<Cargo>
  {
    public Cargo() : base()
    {
    }

    public Cargo(int id, string nome) : base(id, nome)
    {
    }

    public float Salario
    { get; set; } = 0f;

    public int CompareTo(Cargo outro)
    {
      return Nome.CompareTo(outro.Nome);
    }
  }
}