namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula1_FuncoesComParametros;
internal class ClasseExecutora
{
    static void Main()
    {
        OperacoesMatematicas add = new OperacoesMatematicas();
        add.Adicionar(valor1: 12, valor2: 12); /*Aqui uma boa prática,passar os parâmetros nomeados*/
        add.Subtrair(valor1: 32, valor2: 10);
    }
}
