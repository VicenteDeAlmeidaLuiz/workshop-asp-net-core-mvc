namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula2_FuncoesDevolvendoValores;
internal class ExecutoraAula2
{

    static void Main()
    {
        OperacoesMatematicas1 operacoesMatematicas1 = new OperacoesMatematicas1();
        var resultado = operacoesMatematicas1.Adicionar(valor1: 10, valor2: 20);
        Console.WriteLine($"O resultado da soma é {resultado}.");
        var resultadoSubtracao = operacoesMatematicas1.Subtrair(valor1: 30, valor2: 10);
        Console.WriteLine($"O resultado da subtração é {resultadoSubtracao}.");
        operacoesMatematicas1.Multiplicar(valor1: 100, valor2: 3);
        var resultadoDivisao = operacoesMatematicas1.Dividir(valor1: 100, valor2: 10);
        Console.WriteLine(resultadoDivisao);
        /*Imprimindo resultado da divisão de forma separada*/
        Console.WriteLine(resultadoDivisao.ResultadoDaDivisao);
        Console.WriteLine(resultadoDivisao.TextoExplicativo);


    }
}
