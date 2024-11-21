namespace Fundamentos.Modulo3_Colecoes.Aula2_Listas;
internal class AulaListas
{
    static void Main()
    {
        List<int> inteiros = new List<int>();
        inteiros.Add(1);
        inteiros.Add(2);
        inteiros.Add(3);

        Console.WriteLine("O tamanho dessa lista é: " + inteiros.Count);/*Count para tamnho da lista*/
        Console.WriteLine("Valor da lista na posição 0: " + inteiros[0]);/*Acessar os elementos na lista*/
        Console.WriteLine("Valor da lista na posição 1: " + inteiros[1]);
        Console.WriteLine("Valor da lista na posição 2: " + inteiros[2]);
        Console.WriteLine("Removendo o elemento 1: " + inteiros.Remove(1));
        Console.WriteLine("Após remover o valor 1 o valor na posição 0 é o " + inteiros[0]);
        Console.WriteLine("First para imprimir o primeiro elemento: " + inteiros.First());
        Console.WriteLine("Last para imprimir o último elemento: " + inteiros.Last());
        Console.WriteLine("ElementAt para acessar o elemento por posição " + inteiros.ElementAt(1));
        inteiros.RemoveAt(0); /*Remove elementos por index*/
        Console.WriteLine(inteiros.Count);
        inteiros.Clear();/*Remove todos os elemntos da lista*/
        Console.WriteLine(inteiros.Count);

        /*Aqui as listas são de inteiros,mas podem ser string,booleanos,float,classes e etc*/

    }
}
