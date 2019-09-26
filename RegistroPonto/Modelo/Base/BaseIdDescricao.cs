using System;

namespace RegistroPonto.Modelo.Base
{
  public abstract class BaseIdDescricao<T> : BaseId<T>
  {
    private string descricao;

    public BaseIdDescricao() : base()
    {
      descricao = string.Empty;
    }
    
    public BaseIdDescricao(T id) : base(id)
    {
      descricao = string.Empty;
    }

    public BaseIdDescricao(string descricao) : base()
    {
      this.descricao = descricao;
    }

    public BaseIdDescricao(T id, string descricao) : base(id)
    {
      this.descricao = descricao;
    }

    public virtual string Descricao
    {
      get { return descricao;  }
      set { descricao = value; }
    }

    public override string ToString()
    {
      return base.ToString() + string.Format("; Descrição = {0}", descricao);
    }
  }
}
