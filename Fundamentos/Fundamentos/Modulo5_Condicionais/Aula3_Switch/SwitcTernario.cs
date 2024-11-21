namespace Fundamentos.Modulo5_Condicionais.Aula3_Switch;
internal class SwitcTernario
{
    static void Main()
    {
        int numero = 6;

        string resultado = numero switch
        {
            7 => "Vicente",
            1 => "Letícia",
            3 => "Ana Júlia",

            _ => "Nome desconhecido." /*Aqui é como se fosse o default do switch normal*/
        };
        Console.WriteLine(resultado);


    }
}
