using System.Text;

partial class Program
{
    static void AbrirArquivo()
    {
        var enderecoDoArquivo = @"C:\Users\Gabriel\OneDrive\Documentos\Programacao\CSharp\7_Arquivos\contas.txt";
        var buffer = new byte[1024];    //Criamos um vetor de bytes para armazenar o conteudo lido pelo arquivo
                                        //Lembrando que 1024 bytes = 1Kb
        int numeroDeBytesLidos = -1; //Colocamos o valor como -1 pois eh um retono impossivel da funcao read, evitando assim qualquer tipo de confusao

        //Para abrir um arquivo, criamos uma variavel do tipo FileStream, passando o enedereco do arquivo e o modo de leitura como parametros
        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);  //A funcao read faz a leitura do arquivo, recebendo um vetor de bytes para armazenar o conteudo,
                                                                            //a posicao onde iniciaremos a leitura(em relacao ao ultimo ponto de leitura, por default, o ponteiro de leitura inicia na primeira posicao do arquivo),
                                                                            //e quantos bytes devem ser lidos
                LerBuffer(buffer, numeroDeBytesLidos); //Perceba que o que a leitura faz eh realmente ler o valor em bytes(Unicode/ASCII) de cada caractere, cabe a nos fazer a conversao certa de cada caractere.
                                                       //O retorno da funcao read eh o numero de bytes lidos na ultima leitura ou zero caso nao seja mais possivel ler a quantidade de bytes passados no arquivo

            }

        }

        //O bloco using realiza a operacao passada como parametro e libera o espaco alocado apos a execucao do bloco de codigo, sendo uma poderosa ferramenta para economia de memoria    
        //Atencao: o bloco using so pode ser usado para classes que implementem a interface IDisposable

        //fluxoDoArquivo.Close(); //Funcao para fechar o arquivo aberto
        //Apos o fim do bloco using, a variavel eh descartada pelo metodo dispose, que automaticamente chama o metodo Close quando temos um FileStream

        Console.ReadLine();
    }

    static void LerBuffer(byte[] buffer, int bytesLidos)
    {
        /*foreach(var byteBuffer in buffer)
        {
            Console.Write((char)byteBuffer + " ");//Colocando o identificador char, podemos converter os valores dos bytes de cada posicao para sua representacao equivalente
        }*/

        //Outro modo de fazer essa conversao, eh utilizando uma estrutura do proprio .NET que tem o metodo para converter esses bytes para uma string;
        var utf8 = new UTF8Encoding();
        //Na GetString, podemos passar como argumento apenas o buffer ou como da forma abaixo: (buffer, posicao inicial, quantos bytes mostraremos)
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.Write(texto);
    }
}