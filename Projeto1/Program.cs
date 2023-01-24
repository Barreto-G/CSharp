using System;

class programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ola mundo, este eh meu primeiro programa.");
        string var;  //funciona exatamente como no C e C++
        var = Console.ReadLine();
        Console.WriteLine(var);

        //WriteLine escreve o conteudo da variavel e da uma quebra de linha, enquanto o Write apenas escreve o conteudo da variavel
        //Temos os tipos int, double e string assim como no C++

        double valor = 33.13;
        valor = valor + 5.0;

        Console.WriteLine(valor);

        valor++;
        Console.WriteLine(valor);

        //a logica de incremento e decremento de variavel se mantem, utilizando o ++ ou -- antes, faz com que a variavel seja decrementada antes da execucao do codigo da linha.
        //ja colocar depois da variavel (valor++) faz com que a variavel seja incrementada depois da execucao do codigo da linha.
        Console.WriteLine(valor--);
        Console.WriteLine(valor);

        valor = valor + 0.8;
        int valorInteiro;
        valorInteiro = (int)valor; //conversao de double para int, pode ser feito sem a explicitacao em (int), porem, deixa-se claro ao compilador, e a quem ler o codigo, que foi uma conversao intencional, nao um erro de logica
        //A conversao pega apenas os valores ate a virgula, nao fazendo qualquer tipo de arredondamento.
        Console.WriteLine(valorInteiro);

        //long eh o tipo long int do C, representa numeros de ate 64 bits, sendo, em sua essencia, um inteiro.
        long longo;

        //short eh um short int, um inteiro que suporta valores menores, usado caso queira economizar um minimo de memoria
        short curto;

        //float representa numeros decimais com ate uma casa de precisao
        float flutuante = 1.35f;    //Como 0.35 na vdd eh um double, com mais de uma casa de precisao, o f indica que queremos converter para float, simplesmente excluindo as casas decimais nao usadas, sem arredondamento.


        Console.WriteLine("Podemos escrever texto e colocar variaveis no meio assim: "+ flutuante);
        Console.WriteLine("Tambem podemos converter uma variavel apenas na hora de mostra-la na tela, assim: " + (int)flutuante);

        //Variaveis de caracteres e texto podem ser declarados da seguinte forma
        char letra = 'a';
        Console.WriteLine(letra);
        String palavra = "Macaquinho pelado";
        Console.WriteLine(palavra);

        //podemos atribuir um char com seu valor ascii
        char letraAscii = (char)87;
        char letra2 = (char)(87 + 1);
        Console.WriteLine(letraAscii +" " +letra2);

        //temos duas formas de declarar uma string, porem as duas sao equivalentes e possuem o mesmo desempenho e as mesmas caracteristicas
        string word;
        String word2;
        //string eh uma palavra chave do compilador enquanto String eh o nome da classe criada

        //arrays podem ser declarados da seguinte forma:
        int[] vetor;
        int[,] matriz;
        int[][] vetorDeVetores;
        //Nao estabelecemos o tamanho do array pois essa eh apenas a declaracao, para podermos usa-lo, o array deve ser inicializado, como segue:

        //Podemos alocar memoria para um array por meio de sua inicializacao/declaracao
        int[] vetorInicializado = new int[10];

        //ou inicializar um array com valores ja dentro dele
        int[,] matrizInicializada = new int[,] { { 1, 2, 3 }, {4, 5, 6 } };
        int[][] matrizJaggedInicializada = new int[][] 
        {
            new int[] {0,1,2,3 },
            new int[] {4,5,6,7 },
            new int[] {8,9,10,11 }
        };

        //tambem podemos atribuir valores individualmente:
        vetorInicializado[0] = 10;
        matriz = new int[2,2];
        matriz[0, 0] = 10;  //Aqui inicializamos a variavel previamente declarada 'matriz' com o tamanho 2x2, assim, podemos armazenar o valor que quisermos nessas 4 posicoes

        vetorDeVetores = new int[2][];
        vetorDeVetores[0] = new int[] { 0, 1, 2, 3 };   //como essa estrutura eh literalmente um vetor de vetores, primeiro declaramos quantos vetores teremos e depois devemos alocar cada vetor com seu tamanho ou valores individualmente
        //Essa estrutura realmente nao eh uma matriz, se o objetivo eh usar a variavel como matriz, a melhor opcao eh a declaracao mostrada anteriormente.





    }   
}
