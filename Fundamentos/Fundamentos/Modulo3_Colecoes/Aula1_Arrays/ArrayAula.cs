namespace Fundamentos.Modulo3_Colecoes.Aula1_Arrays;
internal class ArrayAula
{
    static void Main()
    {
        int[] inteiros = new int[10]; /*Arrays são coleções com tamnhos fixos,nesse caso o tamanho é 10*/
        inteiros[0] = 1; /*Na posição 0 o valor é 1 e assim sucessivamente*/
        inteiros[1] = 5; /*Na posição 0 o valor é 1 e assim sucessivamente*/
        inteiros[2] = 10;
        Console.WriteLine(inteiros.Length);/*Lenght para verificar o tamanho do array*/
        Console.WriteLine("Na posição 0 do array o valor é " + inteiros[0]);
        Console.WriteLine("Na posição 1 do array o valor é " + inteiros[1]);
        Console.WriteLine("Na posição 2 do array o valor é " + inteiros[2] + "\n");

        Console.WriteLine("___PASSANDO OS VALORES DIRETAMENTE NO ARRAY___\n");
        int[] inteiros1 = [1, 10, 7]; /*Assim o csharp já vai entender que o valor na posição 0 é 1
                                       na posição 1 é 10 e na posição 2 é 7*/
        Console.WriteLine("O tamanho desse array é de " + inteiros1.Length + " elementos.");
        Console.WriteLine("Na posição 0 do array o valor é " + inteiros1[0]);
        Console.WriteLine("Na posição 1 do array o valor é " + inteiros1[1]);
        Console.WriteLine("Na posição 2 do array o valor é " + inteiros1[2]);
    }
}
