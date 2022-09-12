namespace TestDateFormat;
using System.Collections;
using System.Text;
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
        /*List<string> listDate = new List<string>();
        listDate = date.Split("/").ToList();
        int dia = Int32.Parse(listDate[0]);
        int mes = Int32.Parse(listDate[1]);
        int año = Int32.Parse(listDate[2]);*/
        if (date.Length == 10)
        {
            if (date.Substring(2,1) == "/" && date.Substring(5,1) == "/")
            {
                List<string> listDate = new List<string>();
                listDate = date.Split("/").ToList();
                int dia = Int32.Parse(listDate[0]);
                int mes = Int32.Parse(listDate[1]);
                if (dia > 0 && dia <= 31 && mes > 0 && mes <= 12)
                {
                    return listDate[2] + "-" + listDate[1] + "-" + listDate[0];
                }
            }
        }
        return " - - ";
    }

    private bool ComprobarDiaYMes(string dia, string mes, string año)
    {
        if (Int32.Parse(dia) > 0 && Int32.Parse(dia) <= 31 && Int32.Parse(mes) > 0 && Int32.Parse(mes) <= 12)
        {
            return true;
        }
        return false;
    }
}
