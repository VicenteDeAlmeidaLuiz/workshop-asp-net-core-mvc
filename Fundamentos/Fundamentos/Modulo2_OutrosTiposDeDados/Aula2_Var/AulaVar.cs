namespace Fundamentos.Modulo2_OutrosTiposDeDados.Aula2_Var;
internal class AulaVar
{
    static void Main()
    {

        string nome = "Vicente Almeida";
        int meuNumero = 9;

        var nome2 = "Vicente De Almeida"; /*Usando o var eu deixo o copilador escolher automaticamente o tipo da variável*/
        var numero2 = 14;
        var numero3 = 14.69;
        var numero4 = 5.36589f;
        var dataAtual = DateTime.Now;

    }
}
