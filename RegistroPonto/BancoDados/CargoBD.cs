using System;
using System.Data;
using System.Collections.Generic;

using RegistroPonto.Modelo.Entidades;

namespace RegistroPonto.BancoDados
{
  public class CargoBD : BaseBD<Cargo>
  {
    public const string TABELA        = "CARGO";
    public const string CAMPO_ID      = "ID";
    public const string CAMPO_NOME    = "NOME";
    public const string CAMPO_SALARIO = "SALARIO";

    private CargoBD()
    {
    }

    public void Criar(Cargo cargo)
    {
      try
      {
        BancoDadosUtil.Instancia.ExecutarComando
          ($"INSERT INTO {TABELA} ({CAMPO_NOME}, {CAMPO_SALARIO}) VALUES ('{cargo.Nome}', {cargo.Salario})");
        cargo.Id = BancoDadosUtil.Instancia.ObterUltimoIdInserido();
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void Remover(Cargo cargo)
    {
      try
      {
        BancoDadosUtil.Instancia.ExecutarComando($"DELETE FROM {TABELA} WHERE {CAMPO_ID} = {cargo.Id}");
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void Modificar(Cargo cargo)
    {
      try
      {
        BancoDadosUtil.Instancia.ExecutarComando
          ($"UPDATE {TABELA} SET {CAMPO_NOME} = '{cargo.Nome}', {CAMPO_SALARIO} = {cargo.Salario} WHERE {CAMPO_ID} = {cargo.Id}");
      }
      catch (Exception)
      {
        throw;
      }
    }

    public Cargo Recuperar(int id)
    {
      return RecuperarObjeto($"SELECT * FROM {TABELA} WHERE {CAMPO_ID} = {id}", CriarObjetoCargo);
    }

    public List<Cargo> RecuperarTodos()
    {
      return ProcessarConsulta($"SELECT * FROM {TABELA} ORDER BY {CAMPO_NOME}", CriarObjetoCargo);
    }

    private Cargo CriarObjetoCargo(IDataReader resultado)
    {
      Cargo grupo = null;

      try
      {
        grupo = new Cargo();
        grupo.Id = int.Parse(resultado[CAMPO_ID].ToString());
        grupo.Nome = resultado[CAMPO_NOME].ToString();
        grupo.Salario = Convert.ToSingle(resultado[CAMPO_SALARIO]);
      }
      catch (Exception)
      {
        throw;
      }

      return grupo;
    }
  }
}