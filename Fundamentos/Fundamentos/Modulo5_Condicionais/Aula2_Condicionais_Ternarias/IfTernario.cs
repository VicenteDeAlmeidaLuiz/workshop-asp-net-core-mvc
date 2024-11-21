namespace Fundamentos.Modulo5_Condicionais.Aula2_Condicionais_Ternarias;
internal class IfTernario
{
    static void Main()
    {
        int numero = 8;
        string autor;
        /*Condição com if normal*/

        if (numero == 7)
        {
            autor = "Vicente";

        }
        else
        {
            autor = "Letícia";

        }
        Console.WriteLine(autor);

        /*Condição com ternario*/

        string autor1 = numero == 7 ? "Mariana" : "Fernanda";
        Console.WriteLine(autor1);


    }
}
