namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula5_Static;
internal class OperacaoAdicionar
{
    public static int Adicionar(int valor1,int valor2)=> valor1 + valor2;

    /*static significa que eu vou poder utilizar a função mas não pode ser com instância.
     Tem que ser chamando o nome da própria classe.Eu posso também colocar a classe como static
    que ai será uma classe que eu não vou conseguir instanciar.Se a classe for estatica obrigaoriamente
    as funções também devem ser.*/
}
