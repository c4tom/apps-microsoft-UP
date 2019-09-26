using System;
using System.Data;
using System.Collections.Generic;

namespace RegistroPonto.BancoDados
{
  public abstract class BaseBD<T>
  {
    protected delegate T CriarObjeto(IDataReader resultado);

    protected int ProcessarContagem(string sql)
    {
      try
      {
        return BancoDadosUtil.Instancia.ExecutarEscalar(sql);
      }
      catch (Exception)
      {
        throw;
      }
    }

    protected List<T> ProcessarConsulta(string sql, CriarObjeto criarObjeto)
    {
      List<T> lista = new List<T>();
      IDataReader resultado = null;

      try
      {
        resultado = BancoDadosUtil.Instancia.ExecutarConsulta(sql);
        while (resultado.Read())
          lista.Add(criarObjeto(resultado));
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (resultado != null)
          resultado.Close();
      }

      return lista;
    }

    protected T RecuperarObjeto(string sql, CriarObjeto criarObjeto)
    {
      T objeto = default(T);
      IDataReader resultado = null;

      try
      {
        resultado = BancoDadosUtil.Instancia.ExecutarConsulta(sql);
        if (resultado.Read())
          objeto = criarObjeto(resultado);
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (resultado != null)
          resultado.Close();
      }

      return objeto;
    }
  }
}