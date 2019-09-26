using System;
using System.Reflection;

namespace RegistroPonto.Utilidades
{
  public abstract class Singleton<T> where T : class
  {
    class CriadorSingleton
    {
      internal static readonly T instancia = CriadorInstancia();
      
      static CriadorSingleton()
      {
      }
      
      private static T CriadorInstancia()
      {
        ConstructorInfo infoConstrutor =
          typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic,
                                   Type.DefaultBinder, Type.EmptyTypes, null);
        if (infoConstrutor == null)
          return null;
        else
          return infoConstrutor.Invoke(null) as T;
      }
    }
    
    public static T Instancia
    {
      get { return CriadorSingleton.instancia; }
    }
  }
}
