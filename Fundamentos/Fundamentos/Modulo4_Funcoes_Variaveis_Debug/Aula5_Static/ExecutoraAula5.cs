namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula5_Static;
internal class ExecutoraAula5
{
    static void Main()
    {
        int resultado = OperacaoAdicionar.Adicionar(10, 10);/*Aqui chamei a própria classe sem
                                                             instância pq a função é static*/
        Console.WriteLine(resultado);


    }
}
