namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula3_TipoTexto;
internal class TipoTextoContinuacao
{
    static void Main()
    {
        string texto = "Este Curso é Muito Bom";
        bool existeBom = texto.Contains("Bom");/*Existe a palavra curso no texto?*/
        Console.WriteLine(existeBom);
        bool existeOtimo = texto.Contains("Otimo");
        Console.WriteLine(existeOtimo);
        Console.WriteLine("_____________________________________");
        bool igual = texto.Equals("Muito"); /*Verifica se é igual o texto inteiro*/
        Console.WriteLine(igual);
        bool igualTextoCompleto = texto.Equals("Este Curso é Muito Bom");
        Console.WriteLine(igualTextoCompleto);


    }
}
