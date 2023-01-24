using System;
using _5_Excecoes.Contas;
using _5_Excecoes.Titular;
using _5_Exececoes;

class programa
{
    static void Main()
    {
        try         //Podemos tambem tratar excessoes para argumentos de metodos usando a classe ArgumentException
        {
            Cliente barreto = new Cliente("035", "042.066.099-02", "Gabriel Barreto", "dev");

            ContaCorrente conta1 = new ContaCorrente(001,barreto,"012-X");
            ContaCorrente conta2 = new ContaCorrente(001, barreto, "022-H");

            conta1.deposito(1000);
            conta1.sacar(150);

            Console.WriteLine(conta1.Saldo);

            conta2.deposito(1000);
            conta2.transferir(100, conta1);

            
           
        }
        catch (ArgumentException erro)//Como ArgumentException eh uma classe, podemos dar uma referencia a ela
        {
            Console.WriteLine(erro.ParamName);   //Mostra o nome do parametro que gerou a excecao
            Console.WriteLine(erro.Message);    //Mostra a mensagem gerada pelo throw caso ocorra a excessao
            Console.WriteLine(erro.StackTrace); //O Stack trace imprime no console onde a excessao foi lancada e em que linha a execucao parou
        }
        catch(SaldoInsuficienteException ex)    //Podemos alinhar varios catchs, sendo que o retorno em throw vai para o primeiro catch com o mesmo parametro do throw
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Operacao negada! Saldo Insuficiente");
            Console.WriteLine(ex.StackTrace);
        }



        Console.WriteLine(ContaCorrente.TaxaOperacao);
        Console.WriteLine(ContaCorrente.NumContasCriadas);  //Perceba aqui que a segunda conta nao eh criada, isso porque a execucao nao foi completada por conta da excecao

        //--------------------------------------------------------------------------
        //Aqui comeca a ultima parte usando a leitura de arquivos

        LeitorDeArquivo leitor = new LeitorDeArquivo("Contas.txt");
        try
        {
            
            leitor.LerProximaLinha();
            leitor.LerProximaLinha();
            
        }
        catch (IOException)
        {
            Console.WriteLine("Leitura de arquivo interrompida");
        }
        finally //Finally executa o codigo no bloco apos o tratamento das excecoes em catch
        {
            leitor.Dispose();
        }
        

    }
}

//Uma boa pratica para o tratamento de excecoes eh so usa-las quando o erro esperado eh realmente extraordinario, ou seja, nao aconteca com frequencia
//Caso espere que o erro aconteca com frequencia, usar ifs pode ser uma melhor opcao, ja que pode deixar o codigo mais limpo e facil de ler

//Esse codigo eh apenas para estudo e estou ciente que ele esta ilegivel e poderia ser muito otimizado