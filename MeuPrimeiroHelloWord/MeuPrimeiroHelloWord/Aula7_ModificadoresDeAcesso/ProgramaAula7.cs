using MeuPrimeiroHelloWord.Aula7_ModificadoresDeAcesso.CaminhãoDaAulaSete;

namespace MeuPrimeiroHelloWord.Aula7_ModificadoresDeAcesso;
class ProgramaAula7
{
    static void Main()
    {
        CarroAula7 carroAula7 = new CarroAula7();
        carroAula7.LigarCarro();
        carroAula7.DesligarCarro();
        carroAula7.Teste2();
        carroAula7.Separador();
        carroAula7.SeparadorQuebraDeLinha();

        CaminhaoAula7 caminhaoAula7 = new CaminhaoAula7();
        caminhaoAula7.DesligarCaminhao();



    }
}
