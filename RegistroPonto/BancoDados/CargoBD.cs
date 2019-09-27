using System;
using System.Data;
using System.Collections.Generic;

using RegistroPonto.Modelo.Entidades;

namespace RegistroPonto.BancoDados
{
  public class CargoBD : BaseBD<Cargo>
  {
    public const string TABELA        = "cargo";
    public const string CAMPO_ID      = "id";
    public const string CAMPO_NOME    = "nome";
    public const string CAMPO_SALARIO = "salario";

    public CargoBD()
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
      Cargo cargo = null;

      try
      {
        cargo = new Cargo();
        cargo.Id = int.Parse(resultado[CAMPO_ID].ToString());
        cargo.Nome = resultado[CAMPO_NOME].ToString();
        cargo.Salario = Convert.ToSingle(resultado[CAMPO_SALARIO]);
      }
      catch (Exception)
      {
        throw;
      }

      return cargo;
    }
  }
}