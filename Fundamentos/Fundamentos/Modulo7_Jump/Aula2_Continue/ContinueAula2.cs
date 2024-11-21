namespace Fundamentos.Modulo7_Jump.Aula2_Continue;
internal class ContinueAula2
{

    static void Main()
    {
        var numero = 0;

        while (numero < 10)

        {
            numero++;

            if (numero == 5)
            {
                //Console.WriteLine("Pula o cinco e tudo que está baixo e volta la
                //no while");
                continue;

            }
            Console.WriteLine(numero);
            ;

        }
        Console.WriteLine("Sai do looping!!");


    }
}
