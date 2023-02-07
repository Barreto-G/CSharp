using ByteBankIO;
using System.Linq.Expressions;
using System.Text;

partial class Program   //Usar o partial antes da definicao de uma classe nos permite dividir o codigo da mesma em mais de um arquivo, permitindo separar definicoes de metodos e atributos em varios arquivos
{
    static void Main(string[] args)
    {
        CriarArquivoBinario();
        var conta = LeitorBinario();
        Console.WriteLine(conta.ToString());

        Console.ReadLine();
    }


}