namespace Fundamentos.Modulo4_Funcoes_Variaveis_Debug.Aula4_ClassesComValores;
internal class ExecutoraAula4
{

    static void Main()
    {
        //var carro = new CarroAula4();
        ///*Primeira forma de acessar as propriedades*/
        //carro.Modelo = "Lamborghini";
        //carro.Cor = Cor.Vermelho;
        //carro.Lancamento = new DateOnly(2021, 01, 01);

        //carro.NomeDomodelo();
        //carro.DataLancamento();
        //carro.CorDoCarro();
        //carro.Separador();

        ///*Segunda forma de acessar as propriedades*/

        //var carro1 = new CarroAula4
        //{
        //    Modelo = "Porsche",
        //    Lancamento = new DateOnly(2024, 03, 23),
        //    Cor = Cor.Amarelo,
        //};

        //carro1.NomeDomodelo();
        //carro1.DataLancamento();
        //carro1.CorDoCarro();
        //carro1.Separador();

        /*Terceira forma é criando o construtor na classe e parametrizando o que eu quero que seja obrigatório*/
        var carro2 = new CarroAula4("Duster", new DateOnly(2014, 03, 23), Cor.Azul);
        carro2.NomeDomodelo();
        carro2.DataLancamento();
        carro2.CorDoCarro();

    }




}
