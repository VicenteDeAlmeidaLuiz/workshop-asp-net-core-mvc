namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula1_TiposNumericos;
class ClasseAula1


{
    static void Main()
    {
        int numero = 7; /*int para números inteiros*/
        long numero2 = 7;/*long é para números inteiros também porém com uma precisão muito maior*/

        uint numero3 = 7; /*uint só aceita números sem sinal ou seja,só positivos*/

        double numero4 = 3.14; /*double se usa para números com ponto flutuante*/
        float numero5 = 3.14f; /*float se usa para números com ponto flutuante também mas muda a precisão.Precisamos de um f no final*/
        decimal numero6 = 3.14m; /*decimal se usa para números com ponto flutuante também mas muda a precisão.Precisamos de um m no final*/

        Console.WriteLine(numero);
        Console.WriteLine(numero2);
        Console.WriteLine(numero3);
        Console.WriteLine(numero4);
        Console.WriteLine(numero5);
        Console.WriteLine(numero6);


    }

}
