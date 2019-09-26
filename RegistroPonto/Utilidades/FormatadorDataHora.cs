using System;

namespace RegistroPonto.Utilidades
{
  public static class FormatadorDataHora
  {
    public static string FormatarData(DateTime? data)
    {
      if (data == null)
        return string.Empty;
      else
        return string.Format(Constantes.FORMATO_DATA, data);
    }

    public static string FormatarDataComDiaSemana(DateTime? data)
    {
      string dataFormatada = FormatarData(data);
      
      if (string.IsNullOrEmpty(dataFormatada))
        return dataFormatada;

      int diaSemana = (int) data.Value.DayOfWeek;
      return dataFormatada + " (" + Constantes.ABREV_DIA_SEMANA[diaSemana] + ")";
    }

    public static string FormatarDataHora(DateTime? data)
    {
      if (data == null)
        return string.Empty;
      else
        return string.Format(Constantes.FORMATO_DATA_HORA, data);
    }
  }
}
