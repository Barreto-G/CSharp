using ByteBankIO;
using System.Linq.Expressions;
using System.Text;

partial class Program   //Usar o partial antes da definicao de uma classe nos permite dividir o codigo da mesma em mais de um arquivo, permitindo separar definicoes de metodos e atributos em varios arquivos
{
    static void Main(string[] args)
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
                Console.WriteLine(leitor.ReadLine());   //Imprimindo desse modo, linha a linha, evitamos o problema do uso de memoria e temos uma fluidez muito melhor no programa
            }
            

        }
        Console.ReadLine();
    }


}