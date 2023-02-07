using ByteBankIO;
using System.Text;

partial class Program
{

    static void CriarArquivo()
    {
        var caminhoNovoarquivo = "ContasExportadas.csv";    //sem especificar o caminho exato do arquivo, criamos ele na pasta do programa compilado,
                                                            //basicamente, a mesma pasta do executavel
        //O arquivo csv eh um tipo de arquivo de informacoes separadas por virugla, utilizado em planilhas estilo excel
        using(var fluxoDeArquivo = new FileStream(caminhoNovoarquivo, FileMode.OpenOrCreate))
        {
            var contaComoString = "001,1234,4500.50,Gabriel Barreto";
            var encoding = Encoding.UTF8;
            var conteudo = encoding.GetBytes(contaComoString);  //Passamos a string para bytes para armazenarmos no txt/csv
            fluxoDeArquivo.Write(conteudo, 0, conteudo.Length);
        }
        
    }

    static void AbrirArquivoCriado()
    {
        var caminhoNovoarquivo = "ContasExportadas.csv";
        using (var fluxoDeArquivo = new FileStream(caminhoNovoarquivo, FileMode.Open))
        {
            var leitor = new StreamReader(fluxoDeArquivo);
            while (!leitor.EndOfStream) 
            {
                var linha = leitor.ReadLine();
                ContaCorrente auxiliar = ConvertePraConta(linha);
                Console.WriteLine(auxiliar.ToString());
            }
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "ContasExportadas.csv";
        using (var FluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.OpenOrCreate))
        using (var escritor = new StreamWriter(FluxoDeArquivo)) //Podemos colocar dois usings em seguida, seria o mesmo que colocar um dentro das chaves do outro
        {
            
            escritor.WriteLine("001,0364,9900.69, Raffael Barreto");    //A classe streamWriter facilita nossa vida por nao precisarmos fazer a conversao
                                                                    //para bytes para a escrita no arquivo, tudo isso ja eh feito dentro
                                                                    //da funcao Write dessa classe
            escritor.Flush();   //Forca o despejo do buffer de escritor para a Stream, ou seja,
                                //obriga o escritor a salvar as informacoes no momento em que o metodo eh chamado
                                //Caso contrario, pode ser que demore ate que o conteudo seja escrito de fato no arquivo, o que em alguns casos eh 
                                //prejudicial para o programa, como em casos de erro ou informacoes de log,
                                //caso o programa de algum erro, todas as informacoes que nao foram salvas sao perdidas
        }
    }

}