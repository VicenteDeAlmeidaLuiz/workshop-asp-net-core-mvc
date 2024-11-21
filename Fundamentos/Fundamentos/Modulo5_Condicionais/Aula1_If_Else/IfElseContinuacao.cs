namespace Fundamentos.Modulo5_Condicionais.Aula1_If_Else;
internal class IfElseContinuacao
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

        if (cor == Cores.Azul && numero >= 0 && ativo)
        {
            Console.WriteLine("ENTROOUUU");

        }



    }
}
