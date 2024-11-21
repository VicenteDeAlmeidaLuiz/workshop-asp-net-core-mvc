namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula5_DataEHora;
internal class DataEHoraContinuacao
{
    static void Main()
    {

        DateTime hoje = DateTime.UtcNow;/*UtcNow fornece a data e hora do momento exato com base 
                                         * no relógio universal(3 horas a mais que o gmt do Brasil), em vez de um fuso horário local específico.*/
        Console.WriteLine(hoje);
        DateTime addDias = hoje.AddDays(1);
        Console.WriteLine(addDias);






    }
}
