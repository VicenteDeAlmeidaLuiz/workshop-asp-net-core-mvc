namespace Fundamentos.Modulo7_Jump.Aula3_Return;
internal class Aula3Return
{

    static void Main()
    {
        var numero = 0;

        while (numero < 10)

        {
            numero++;

            if (numero == 5)
            {
                return; /*Tem a mesma função do break,porém return usamos também nas funções e break não*/

            }
            Console.WriteLine(numero);
            ;

        }
        Console.WriteLine("Sai do looping!!");


    }
}
