namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula4_OperacoesComTexto;
internal class OperacoesComString
{
    static void Main()
    {
        string texto1 = "A primeira frase.";
        string texto2 = "A segunda frase.";

        string paragrafo = texto1 + " " + texto2;
        Console.WriteLine(paragrafo);

        string barraTTab = "Vicente\tAlmeida\tLuiz";/*Barra t seria o tab*/
        Console.WriteLine(barraTTab);
        string barraNQuebralinha = "Vicente\nAlmeida\nLuiz"; /*Barra n quebra linha*/
        Console.WriteLine(barraNQuebralinha);
        Console.WriteLine("____________________________________________");
        string ignoraBarraT = @"Vicente\tAlmeida\tLuiz";
        string ignoraBarraN = @"Vicente\nAlmeida\nLuiz";
        Console.WriteLine(ignoraBarraT);
        Console.WriteLine(ignoraBarraN);
        Console.WriteLine("____________________________________________");
        string interpolacaoDeString = "String interpolada.";
        Console.WriteLine($"Isso aqui é uma {interpolacaoDeString}");
        Console.WriteLine($"Posso usar outros tipos de dados na {interpolacaoDeString}{7} {true}");




    }
}
