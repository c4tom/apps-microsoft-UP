namespace RegistroPonto.Modelo.Base
{
  public abstract class BaseIdNome<T> : BaseId<T>
  {
    private string nome;

    public BaseIdNome() : base()
    {
      this.nome = string.Empty;
    }

    public BaseIdNome(T id) : base(id)
    {
      this.nome = string.Empty;
    }

    public BaseIdNome(string nome) : base()
    {
      this.nome = nome;
    }

    public BaseIdNome(T id, string nome) : base(id)
    {
      this.nome = nome;
    }

    public string Nome
    {
      get { return nome;  }
      set { nome = value; }
    }
  }
}