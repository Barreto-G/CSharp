using ByteBankIO;

partial class Program
{
    static void LerComStreamReader()
    {
        var enderecoDoArquivo = @"C:\Users\Gabriel\OneDrive\Documentos\Programacao\CSharp\7_Arquivos\contas.txt";
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDoArquivo);  //Se trata de uma classe que contem todas as funcoes de leitura de arquivo inclusas, sem que precisemos converter manualmente os dados ou criar buffers

            //var linha = leitor.ReadLine();  //Funcao para ler apenas uma linha do arquivo, basicamente, ele le o arquivo ate encontrar uma quebra de linha

            //var texto = leitor.ReadToEnd(); //Funcao para ler todo o arquivo de uma vez                                             
            //Devemos tomar cuidado com o ReadToEnd, pois para arquivos muito grandes, ja que,                                              
            //quando a funcao tentar armazenar todo o conteudo de uma vez, em uma unica variavel, pode acabar gerando um uso excessivo da memoria e travar a maquina

            //var numero = leitor.Read(); //Esta funcao le um unico byte do arquivo, retornando seu valor

            while (!leitor.EndOfStream) //Retorna true se a leitura do arquivo chegou ao fim e false se nao
            {
                var linha = leitor.ReadLine();
                ContaCorrente auxiliar = ConvertePraConta(linha);
                Console.WriteLine(auxiliar.ToString());   //Imprimindo desse modo, linha a linha, evitamos o problema do uso de memoria e temos uma fluidez muito melhor no programa
            }


        }
    }

    public static ContaCorrente ConvertePraConta(string linha)
    {
        var divide = linha.Split(',');  //A funcao split retorna um vetor de strings com o conteudo separado a cada ',' encontrado
        var agencia = int.Parse(divide[0]); //A funcao Parse converte o conteudo da String para o tipo que chama a funcao
        var numDaConta = int.Parse(divide[1]);
        var saldoString = divide[2].Replace('.', ','); //A funcao replace troca os pontos por virgula na string para que a funcao parse entenda que sao casas decimais
        var saldo = double.Parse(saldoString);
        var nomeTitular = divide[3];

        ContaCorrente user = new ContaCorrente(agencia, numDaConta);
        user.Depositar(saldo);
        user.Titular = new Cliente();
        user.Titular.Nome = nomeTitular;

        return user;
    }
}