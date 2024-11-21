namespace MeuPrimeiroHelloWord.Aula7_ModificadoresDeAcesso;
internal class CarroAula7
{
    public void LigarCarro()
    {
        Console.WriteLine("Vamos lá meu carro,ligue-se!!");
    }
    public void DesligarCarro()
    {
        Console.WriteLine("Função pública,qualquer outra classe que possuir uma instância vai poder usar essa função");
    }
    private void Teste1()
    {
        Console.WriteLine("Função private somente a pópria classe vai poder utilizar a função");
        Console.WriteLine("Se eu declarar a função somente como void (sem nenhum modificador de acesso,automaticamente ela será também private)");
    }
    internal void Teste2()
    {
        Console.WriteLine("Função internal,somente classes do mesmo projeto vão poder usar a função");
        Console.WriteLine("Para classes internal tem a mesma função também,se eu não declarar o internal na classe mesmo assim o c# vai entender " +
            "que a classe é internal");
    }

    public void Separador() {

        Console.WriteLine("_____________________________________________________________");
    }
    public void SeparadorQuebraDeLinha()
    {

        Console.WriteLine();
    }
}
