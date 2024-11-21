namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula3_ParametrosOpcionais;

internal class ExecutoraAula3
{

    static void Main()
    {

        var operacoesMatematicas = new OperacoesMatematicasAula3();
        operacoesMatematicas.Teste(valor1: 10); /*Como o valor 2 é opcional não é gerado nenhum erro*/
        operacoesMatematicas.Teste(valor1: 10, valor2: 8); /*Se eu passar o valor 2 ele sobrescreve o que eu defini na função*/





    }
}
