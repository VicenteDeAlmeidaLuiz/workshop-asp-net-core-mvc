namespace Fundamentos.Modulo2_OutrosTiposDeDados.Aula1_Enums;
internal class AulaEnums
{

    enum NiveDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2,


    }

    static void Main()
    {

        NiveDeDificuldade nivel = NiveDeDificuldade.Alto;
        int nivelInteiro = (int)nivel;
        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);

    }
}
