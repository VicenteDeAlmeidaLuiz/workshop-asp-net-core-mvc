namespace Fundamentos.Modulo1_TiposPrimitivosDeDados.Aula3_TipoTexto;
internal class TipoTexto

{
    static void Main()
    {
        /*Variáveis do tipo Texto
         char
        string*/

        char letra = 'a'; /*char suporta apenas um caracter entre aspas simples*/
        char numero = '1';
        char caracter = '@';

        //Para textos usamos o tipo string que é um conjunto de char,caracteres

        string texto = "Este curso é muito bom";
        char primeiraLetraDoTexto = texto[0];

        Console.WriteLine(texto);
        Console.WriteLine(primeiraLetraDoTexto);
        Console.WriteLine("_____________________________________________");

        string meuNome = "                   Vicente                         ";
        string meuNomeSemEspacos = meuNome.Trim();
        Console.WriteLine(meuNome);
        Console.WriteLine(meuNomeSemEspacos);
        Console.WriteLine("_____________________________________________");
        string meuNomeESobrenome = "                   Vicente Almeida                      ";
        string meuNomeESobrenome1 = meuNomeESobrenome.Trim();
        Console.WriteLine(meuNomeESobrenome);
        Console.WriteLine("O trim não remove os espaços do meio,somente do inicio e do fim " + meuNomeESobrenome1);
        Console.WriteLine("_____________________________________________");
        string nomeDela = "Leticia";
        bool comecaComL = nomeDela.StartsWith("L"); /*Retorna booleano,como se estivesse fazendo uma pergunta
                                                     nome dela começa com L?.Diferencia maíusculo e minusculo*/
        Console.WriteLine(comecaComL);
        bool terminaComA = nomeDela.EndsWith("j");
        Console.WriteLine(terminaComA);
        Console.WriteLine("_____________________________________________");
        string textoAposReplace = nomeDela.Replace('i', '7'); /*Replace troca os caracteres,nesse caso onde tem i substitui por 7*/
        Console.WriteLine(textoAposReplace);




    }


}
