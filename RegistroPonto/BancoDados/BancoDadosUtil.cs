using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

using RegistroPonto.Utilidades;

namespace RegistroPonto.BancoDados
{
  public class BancoDadosUtil : Singleton<BancoDadosUtil>, IDisposable
  {
    private const string NOME_BANCO_DADOS = "ponto.db";

    private string expressaoConexao = string.Empty;
    private SQLiteConnection connection;

    private BancoDadosUtil()
    {
      Inicializar();
    }

    public void Dispose()
    {
      Desconectar();
    }

    public bool Conectado
    {
      get
      {
        return (connection != null && connection.State == ConnectionState.Open);
      }
    }

    public void Conectar()
    {
      Desconectar();

      try
      {
        connection = new SQLiteConnection();
        connection.ConnectionString = expressaoConexao;
        connection.Open();
        PragmaForeignKeysON();
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void Desconectar()
    {
      if (connection != null && connection.State == ConnectionState.Open)
        connection.Dispose();
    }

    public void ExecutarComando(string sql)
    {
      SQLiteCommand comando = null;

      try
      {
        if (!Conectado)
          Conectar();
        comando = new SQLiteCommand(sql, connection);
        comando.ExecuteNonQuery();
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (comando != null)
          comando.Dispose();
      }
    }

    public IDataReader ExecutarConsulta(string sql)
    {
      IDataReader resultado = null;
      SQLiteCommand consulta = null;

      try
      {
        if (!Conectado)
          Conectar();
        consulta = new SQLiteCommand(sql, connection);
        resultado = consulta.ExecuteReader();
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (consulta != null)
          consulta.Dispose();
      }

      return resultado;
    }

    public int ExecutarEscalar(string sql)
    {
      int resultado = 0;

      SQLiteCommand escalar = null;

      try
      {
        if (!Conectado)
          Conectar();
        escalar = new SQLiteCommand(sql, connection);
        resultado = Convert.ToInt32(escalar.ExecuteScalar());
      }
      catch (Exception)
      {
        throw;
      }
      finally
      {
        if (escalar != null)
          escalar.Dispose();
      }

      return resultado;
    }

    public int ObterUltimoIdInserido()
    {
      return ExecutarEscalar("SELECT last_insert_rowid()");
    }

    private void PragmaForeignKeysON()
    {
      ExecutarEscalar("PRAGMA foreign_keys = ON;");
    }

    private void Inicializar()
    {
      string bancoDados =
        Constantes.PASTA_APLICACAO + NOME_BANCO_DADOS;

      if (!File.Exists(bancoDados))
      {
        string bancoDadosVazio =
          Constantes.PASTA_EXECUTAVEL + NOME_BANCO_DADOS;
        
        if (File.Exists(bancoDadosVazio))
          File.Copy(bancoDadosVazio, bancoDados);
      }

      expressaoConexao = "Data Source=" + bancoDados;
    }
  }
}