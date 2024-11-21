namespace Fundamentos.Modulo3_Colecoes.Aula3_MaisSobreListas;
internal class MaisAulasSobreListas
{
    static void Main()
    {
        List<string> nomes = new List<string>();
        nomes.Add("Vicente");
        nomes.Add("Letícia");
        nomes.Add("Ana Júlia");
        string resultado = string.Join(",", nomes);
        Console.WriteLine($"União de todas as strings: {resultado}.");
        List<int> idades = new List<int>();
        idades.Add(43);
        idades.Add(44);
        idades.Add(12);
        List<decimal> decimais = new List<decimal>();
        decimais.Add(1.5m);
        decimais.Add(2.5m);
        decimais.Add(3.9m);
        List<bool> verdadiroOuFalso = new List<bool>();
        verdadiroOuFalso.Add(true);
        verdadiroOuFalso.Add(false);
        Console.WriteLine();

        Console.WriteLine("___USANDO O OBJECT EU POSSO COLOCAR QUALQUER TIPO NA LISTA___");
        List<object> listaDeObjetos = new List<object>();
        listaDeObjetos.Add("Vicente");
        listaDeObjetos.Add(43);
        listaDeObjetos.Add(9.63);
        listaDeObjetos.Add(true);
        listaDeObjetos.Add(false);
        Console.WriteLine(listaDeObjetos.Count);


    }
}
