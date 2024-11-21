namespace Fundamentos.Modulo5_Condicionais.Aula1_If_Else;
internal class Programa
{
    enum Cores
    {
        Vermelho,
        Azul,
        Amarelo


    }

    static void Main()
    {
        int numero = -10;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Vicente";
        List<int> lista = new List<int> { 1, 7 };
        Cores cor = Cores.Azul;

        /*
         > Maior
        < Menor
        >= Maior ou igual
        <= Menor ou igual
        != Diferente
        == Igualdade
        */

        if (numero > 0)
        {
            Console.WriteLine("Este número é POSITIVO");

        }
        else if (numero == 0)
        {
            Console.WriteLine("Esse número é NEUTRO");

        }
        else
        {
            Console.WriteLine("Esse número é NEGATIVO");
        }


    }
}
