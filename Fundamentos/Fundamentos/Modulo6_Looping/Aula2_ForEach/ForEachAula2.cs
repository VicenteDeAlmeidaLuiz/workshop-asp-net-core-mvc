using System.Runtime.CompilerServices;

namespace Fundamentos.Modulo6_Looping.Aula2_ForEach;
internal class ForEachAula2
{
    static void Main()
    {
        var listaNomes = new List<string> { "Vicente", "Marcelo", "Roberto" };

        foreach (var nomes in listaNomes)
        {
            Console.WriteLine(nomes);

        }


    }
}
