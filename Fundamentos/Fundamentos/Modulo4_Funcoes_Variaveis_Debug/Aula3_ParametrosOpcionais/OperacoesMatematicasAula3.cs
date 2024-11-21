namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula3_ParametrosOpcionais;
internal class OperacoesMatematicasAula3
{
    public (int resultadoDaAdicao, string autor) Adicionar(int valor1, int valor2)
    {
        var resultadoDaAdicao = valor1 + valor2;
        return (resultadoDaAdicao, "Vicente");
    }

    public void Teste(int valor1,int valor2 = 7) { 
        /*Estou transaformando o valor 2 em opcional,mas isso não é aceito no primeiro parâmetro*/

        Console.WriteLine(valor1 + valor2);
    }
}
