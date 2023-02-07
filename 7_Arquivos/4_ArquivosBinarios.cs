using ByteBankIO;

partial class Program
{
    static void CriarArquivoBinario()   //Trabalhar com arquivos binarios eh muito melhor para o quesito de usar menor memoria e ganhar mais eficiencia
    {
        var caminhoNovoArquivo = "ArquivoBinario.txt";
        using (var FluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.OpenOrCreate))
        using (var escritor = new BinaryWriter(FluxoDeArquivo)) //Assim como o StreamWriter tinha funcoes para escrita de um arquivo de texto,
        {                                                       //o BinaryWriter apresenta diversos metodos para escrita de arquivos binarios diretamente
        

            escritor.Write(001);    //Aqui temos apenas o Write, ja que arquivos binarios nao trabalham com texto em si, mas com a representacao binaria do conteudo
            escritor.Write(0364);   //Devemos inserir dado a dado, com seu respectivo tipo passado da forma certa, para termos uma leitura correta posteriormente
            escritor.Write(9900.69);
            escritor.Write("Raffael Barreto");
            escritor.Flush();


        }
    }

    static ContaCorrente LeitorBinario()
    {
        var caminhoNovoArquivo = "ArquivoBinario.txt";
        using (var FluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.OpenOrCreate))
        using (var leitor = new BinaryReader(FluxoDeArquivo)) //A classe Binary reader contem os metodos para realizar a leitura de um arquivo binario
        {
            var agencia = leitor.ReadInt32();
            var numConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var nomeTitular = leitor.ReadString();

            var aux = new ContaCorrente(agencia, numConta);
            aux.Depositar(saldo);
            aux.Titular = new Cliente();
            aux.Titular.Nome = nomeTitular;
            return aux;
        }

    }




}