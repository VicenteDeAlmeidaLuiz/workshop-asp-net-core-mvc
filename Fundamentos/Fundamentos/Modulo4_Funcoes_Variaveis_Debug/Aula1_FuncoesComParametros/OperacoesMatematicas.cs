namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula1_FuncoesComParametros;
internal class OperacoesMatematicas
{
    public void Adicionar(double valor1,double valor2) {

        double resultado = valor1 + valor2;
        Console.WriteLine($"A soma dos números {valor1} e {valor2} é {resultado}.");
    
    
    
    } /*Void é uma função que não precisa retornar nada*/

    public void Subtrair(double valor1, double valor2)
    {

        double resultado = valor1 - valor2;
        Console.WriteLine($"A subtração dos números {valor1} e {valor2} é {resultado}.");



    }
}
