using _3_OrientacaoAObjetos.Contas;
using _3_OrientacaoAObjetos.Titular;

/*ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "Andre";
contaDoAndre.conta = "101-A";
contaDoAndre.saldo = 1000.25;
contaDoAndre.num_agencia = 1;

Console.WriteLine(contaDoAndre.titular);

if (contaDoAndre.sacar(50))
{
    Console.WriteLine("Saque realizado com sucesso, novo saldo do Andre eh: R$" + contaDoAndre.saldo);
}
else { Console.WriteLine("Nao eh possivel sacar esse valor."); }


ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria";
contaDaMaria.conta = "102-A";
contaDaMaria.saldo = 10;
contaDaMaria.num_agencia = 1;

if (contaDoAndre.transferir(10.00, contaDaMaria))
{
    Console.WriteLine("Andre transferiu dinheiro para Maria.");
}
else { Console.WriteLine("Andre nao tinha dinheiro suficiente para transferir para Maria."); }

Console.WriteLine("Saldo de Andre: R$"+contaDoAndre.saldo);
Console.WriteLine("Saldo de Maria: R$" +contaDaMaria.saldo);

//No C# sempre estamos utilizando ponteiros por definicao, sem a necessidade de usar o * como no C++
//Portanto, ao definirmos uma igualdade do tipo
ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = conta1;
//Ambos conta1 e conta2 referenciam o mesmo espaco na memoria, entao qualquer modificacao em um, tambem modificara o outro.

conta2.saldo = 1000;
Console.WriteLine(conta1.saldo);*/

/*Cliente pessoa = new Cliente();
pessoa.Nome = "Jeff";
pessoa.Profissao = "Pedreiro";

ContaCorrente conta = new ContaCorrente();
conta.titular = pessoa;
//conta.saldo = 1000;
conta.SetSaldo(1000);
conta.conta = "1001-Z";

Console.WriteLine("O Titular da conta eh: "+ conta.titular.Nome);
Console.WriteLine("Seu saldo eh de : " + conta.GetSaldo() + " reais.");

pessoa.Nome = "Jefferson";  //pessoa e o titular da conta criada apontam pro mesmo espaco de memoria, se um eh modificado, os dois sao
Console.WriteLine("O Titular da conta eh: " + conta.titular.Nome);


ContaCorrente conta2 = new ContaCorrente();
conta2.titular = new Cliente(); //Outra forma de alocarmos um espaco na memoria para o objeto cliente dentro de ContaCorrente

conta2.titular.Nome = "Claudio";
Console.WriteLine(conta2.titular.Nome); //Ao usar propriedades, nao precisamos especificar se estamos usando o get ou o set, o proprio compilador entende o uso e chama uma das funcoes
*/

Cliente jeferson = new Cliente("012","032");
jeferson.Nome = "Jeferson";

ContaCorrente conta = new ContaCorrente(321, jeferson, "512-X");
ContaCorrente conta2 = new ContaCorrente(321, jeferson, "513-X");
ContaCorrente conta3 = new ContaCorrente(321, jeferson, "514-X");    //criando varios objetos para verificar a variavel estatica

Console.WriteLine(ContaCorrente.NumContasCriadas); //Para variaveis estaticas, referenciamos a classe e nao um objeto dela