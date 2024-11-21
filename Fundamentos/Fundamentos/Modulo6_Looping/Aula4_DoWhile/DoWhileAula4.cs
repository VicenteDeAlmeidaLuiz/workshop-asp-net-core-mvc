namespace Fundamentos.Modulo6_Looping.Aula4_DoWhile;
internal class DoWhileAula4
{
    static void Main()
    {
        var numero = 10;

        do
        {
            Console.WriteLine("Teste");
            numero++;
        }

        while (numero < 10);


        Console.WriteLine(numero);


    }
}
