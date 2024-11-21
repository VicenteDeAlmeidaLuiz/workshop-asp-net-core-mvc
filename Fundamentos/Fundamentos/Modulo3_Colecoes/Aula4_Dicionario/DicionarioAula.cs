using System.Globalization;

namespace Fundamentos.Modulo3_Colecoes.Aula4_Dicionario;
internal class DicionarioAula
{
    static void Main()
    {
        Dictionary<int, string> chaveValor = new Dictionary<int, string>();
        chaveValor.Add(1, "Vicente");
        chaveValor.Add(2, "Almeida");
        chaveValor.Add(3, "Letícia");
        chaveValor.Add(4, "Colvara");

        string valor2 = chaveValor[2];
        string valor4 = chaveValor[4];
        Console.WriteLine($"Valor associado a chave 2: {valor2}");
        Console.WriteLine($"Valor associado a chave 4: {valor4}");

        Dictionary<string, int> chaveValor2 = new Dictionary<string, int>();
        chaveValor2.Add("Vicente", 1);
        chaveValor2.Add("Almeida", 2);
        chaveValor2.Add("Letícia", 3);
        chaveValor2.Add("Colvara", 4);

        int valor = chaveValor2["Vicente"];
        int valor1 = chaveValor2["Letícia"];

        Console.WriteLine($"Valor associado a chave Vicente {valor}");
        Console.WriteLine($"Valor associado a chave Letícia {valor1}");

        bool existeAChave = chaveValor2.ContainsKey("Maria");
        Console.WriteLine($"{existeAChave}");


    }
}
