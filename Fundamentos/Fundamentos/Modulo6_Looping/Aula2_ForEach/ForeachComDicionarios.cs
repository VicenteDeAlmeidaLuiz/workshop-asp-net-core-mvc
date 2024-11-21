namespace Fundamentos.Modulo6_Looping.Aula2_ForEach;
internal class ForeachComDicionarios
{
    static void Main()
    {
        var dicionario = new Dictionary<int, string>();
        dicionario.Add(1, "Vicente");
        dicionario.Add(2, "Lígia");
        dicionario.Add(3, "Flávio");

        foreach (var nomes in dicionario)
        {
            Console.WriteLine(nomes);

        }
        Console.WriteLine("Pegando apenas a chave");

        foreach (var nomes in dicionario)
        {
            Console.WriteLine(nomes.Key);

        }

        Console.WriteLine("Pegando apenas o valor");

        foreach (var nomes in dicionario)
        {
            Console.WriteLine(nomes.Value);

        }




    }
}
