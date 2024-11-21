namespace Fundamentos.Modulo5_Condicionais.Aula3_Switch;
internal class SwitchAula3
{
    enum Cores
    {
        Azul,
        Vermelho,
        Amarelo,
        Verde,
        Roxo

    }

    static void Main()
    {

        Cores cor = Cores.Roxo;


        switch (cor)
        {
            case Cores.Azul:
                {
                    Console.WriteLine("Cor azul");

                }
                break;
            case Cores.Vermelho:
                {
                    Console.WriteLine("Cor vermelho");


                }
                break;
            case Cores.Amarelo:
                {

                    Console.WriteLine("Cor Amarelo");
                }
                break;
            case Cores.Verde:
                {
                    Console.WriteLine("Cor Verde");

                }
                break;
            default:
                {
                    Console.WriteLine("Outra cor");


                }
                break;


        }


    }
}
