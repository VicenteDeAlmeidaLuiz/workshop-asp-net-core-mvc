using System;
namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula4_OperacoesComTexto;
class OperacoesComStringContinuacao
{
    static void Main()
    {
        string meuTexto = "O usuário {0} gosta do número {1}";
        string resultado = string.Format(meuTexto, "Vicente", 7);
        Console.WriteLine(resultado);



    }
}
