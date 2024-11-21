namespace Fundamentos.Modulo6_Looping.Aula1_For;
internal class ForAula1
{
    static void Main()
    {
        var lista = new List<string> { "Vicente", "Eu Mesmo", "Por Mim" };
        /*For na lista*/
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);


        }
        /*For normal*/
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);

        }


    }
}
