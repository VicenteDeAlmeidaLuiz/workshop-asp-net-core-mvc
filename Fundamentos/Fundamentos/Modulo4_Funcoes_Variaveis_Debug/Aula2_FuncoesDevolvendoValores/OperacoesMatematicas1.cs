namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula2_FuncoesDevolvendoValores;
internal class OperacoesMatematicas1
{
    public double Adicionar(double valor1, double valor2)
    {

        return valor1 + valor2;
    }
    /*Outra maneira de retornar valores quando utilizarmos somente uma linha*/

    public double Subtrair(double valor1, double valor2) => valor1 - valor2;

    /*Outra maneira já usando o cw direto*/

    public void Multiplicar(double valor1, double valor2) => Console.WriteLine($"Resultado da multiplicação: {valor1 * valor2}.");
    /*Para usar assim a função tem que ser void*/

    public (int ResultadoDaDivisao, string TextoExplicativo) Dividir(int valor1, int valor2)
    {

        int resultadoDivisao = valor1 / valor2;

        return (resultadoDivisao, "é o resultado da divisão");


    }
    /*Função para quando precisar retornar mais de um resultado*/
}
