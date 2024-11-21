namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula4_ClassesComValores;
internal class CarroAula4
{
    public /*required*/ string Modelo { get; set; } /*Aqui é o que chamamos de propriedades
                                                 required quer dizer que quando eu instancio a classe
    essa propriedade é obrigatória na instanciação*/
    public DateOnly Lancamento { get; set; }

    public Cor Cor { get; set; }

    public CarroAula4(string modelo, DateOnly lancamento, Cor cor)
    {
        Modelo = modelo;
        Lancamento = lancamento;
        Cor = cor;
    }

    public void NomeDomodelo() => Console.WriteLine(Modelo);
    public void DataLancamento() => Console.WriteLine(Lancamento);
    public void CorDoCarro() => Console.WriteLine(Cor);
    public void Separador() => Console.WriteLine("\n__________________________________\n");

}

