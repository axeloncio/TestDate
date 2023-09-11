using System;
namespace Ucu.Poo.Persons;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {   
        if (date.Length < 10)
        {
            return "";
        }
        //Revisar que la fecha no sea inválida

        int day = int.Parse(date.Substring(0, 2));
        int month = int.Parse(date.Substring(3, 2));
        int year = int.Parse(date.Substring(6));

        if (day < 1 || day > 31)
        {
            return "";
        }

        if (month < 1 || month > 12)
        {
            return "";
        }

        //Revisar que la fecha no sea nula
        if (string.IsNullOrEmpty(date))
        {
            return "";
        }
        
        else
        {
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
    }
}
