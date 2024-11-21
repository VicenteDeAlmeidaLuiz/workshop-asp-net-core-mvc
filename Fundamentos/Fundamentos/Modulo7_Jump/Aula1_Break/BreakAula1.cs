namespace Fundamentos.Modulo7_Jump.Aula1_Break;
internal class BreakAula1
{
    static void Main()
    {
        var numero = 0;

        while (numero < 100)
        {

            if (numero == 5)
            {
                Console.WriteLine("Encerra a execução no 5");
                break;

            }
            Console.WriteLine(numero);
            numero++;

        }
        Console.WriteLine("Sai do looping!!");


    }
}
