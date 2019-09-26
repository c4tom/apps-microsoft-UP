using System;
using System.IO;
using System.Reflection;
using System.Globalization;

namespace RegistroPonto.Utilidades
{
  public static class Constantes
  {
    public const int IGUAL = 0;
    public const int MAIOR = 1;
    public const int MENOR = -1;

    public const char PONTO   = '.';
    public const char VIRGULA = ',';

    public const string MASCARA_DATA      = "dd/MM/yyyy";
    public const string MASCARA_DATA_HORA = "dd/MM/yyyy HH:mm";

    public const string FORMATO_DATA      = "{0:dd/MM/yyyy}";
    public const string FORMATO_DATA_HORA = "{0:dd/MM/yyyy HH:mm:ss}";

    public static readonly string APL_NOME;
    public static readonly string PASTA_APLICACAO;
    public static readonly string PASTA_EXECUTAVEL;

    public static readonly string[] ABREV_DIA_SEMANA =
      { "dom", "seg", "ter", "qua", "qui", "sex", "sáb" };

    public static readonly string[] NOME_MES =
      { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

    public static readonly CultureInfo BRASIL =
      new CultureInfo("pt-BR");

    static Constantes()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();

      AssemblyTitleAttribute[] title = (AssemblyTitleAttribute[])
        assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);

      if (title != null && title.Length > 0)
        APL_NOME = title[0].Title;
      else
        APL_NOME = string.Empty;

      string pasta = Path.Combine
        (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APL_NOME);

      CriarPasta(pasta);

      PASTA_APLICACAO = pasta + Path.DirectorySeparatorChar;
      PASTA_EXECUTAVEL = Path.GetDirectoryName(assembly.Location) + Path.DirectorySeparatorChar;
    }

    private static void CriarPasta(string pasta)
    {
      if (!Directory.Exists(pasta))
        Directory.CreateDirectory(pasta);
    }
  }
}