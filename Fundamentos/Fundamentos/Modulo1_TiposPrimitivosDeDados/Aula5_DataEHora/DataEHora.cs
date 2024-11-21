using System.Globalization;

namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula5_DataEHora;
internal class DataEHora
{
    static void Main()
    {
        DateOnly dia = new DateOnly(2024, 12, 1);
        Console.WriteLine(dia);
        string diaEmTexto = dia.ToLongDateString(); /*Aqui mostra o dia e melhora formato da data*/
        Console.WriteLine(diaEmTexto);
        Console.WriteLine("______________________________");
        string diaEmTextoTraducao = dia.ToString("D", new CultureInfo("en-us"));/*Traduzindo para data e hora dos Eua*/
        string diaEmTextoTraducao1 = dia.ToString("dd MMMM yyyy", new CultureInfo("en-us"));/*Com dia mês e ano*/
        string formatandoComBarras = dia.ToString("dd/MMMM/yyyy", new CultureInfo("en-us"));
        Console.WriteLine(diaEmTextoTraducao);
        Console.WriteLine(diaEmTextoTraducao1);
        Console.WriteLine(formatandoComBarras);
        Console.WriteLine("_______________________________________");
        DateTime hoje = DateTime.Now; /*Data e hora do exato momento*/
        Console.WriteLine(hoje);





    }
}
