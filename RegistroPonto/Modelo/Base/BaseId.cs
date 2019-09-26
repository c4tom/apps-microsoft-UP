namespace RegistroPonto.Modelo.Base
{
  public abstract class BaseId<T>
  {
    private T id;

    public BaseId()
    {
      this.id = default(T);
    }

    public BaseId(T id)
    {
      this.id = id;
    }

    public T Id
    {
      get { return id;  }
      set { id = value; }
    }
  }
}
