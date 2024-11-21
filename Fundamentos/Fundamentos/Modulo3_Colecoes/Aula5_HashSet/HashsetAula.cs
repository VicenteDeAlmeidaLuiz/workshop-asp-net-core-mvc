namespace Fundamentos.Modulo3_Colecoes.Aula5_HashSet;
internal class HashsetAula
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(1);
        Console.WriteLine(set.Count); /*No count do hashset ele desconsidera valores repetidos
                                       então o resultado aqui é 2.Hashset é uma lista de valores 
        únicos*/

    }
}
