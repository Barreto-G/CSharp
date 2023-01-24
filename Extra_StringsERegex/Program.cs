string Hello = "Ola Mundo";
Console.WriteLine(Hello);
Console.WriteLine(Hello.ToUpper()); //usando essa diretiva, imprimimos o conteudo da string em letra maiuscula
                                    //Observe que o conteudo da string nao eh modificado, isso pq eh criada uma copia da string para que ela seja mostrada no console

Console.WriteLine(Hello.ToLower()); //Mesma coisa acontece com o toLower, porem, todas as letras ficam minusculas

string nome = "Gabriel";
string sobrenome = "Barreto";
string nomeCompleto = nome + " " + sobrenome;
Console.WriteLine(nomeCompleto);    //Podemos concatenar strings em uma variavel nova ou no proprio console 
Console.WriteLine(nome + " " + sobrenome);     //Perceba que dessa forma as duas variaveis nao sao modificadas, novamente, uma variavel auxiliar eh criada para a concatenacao do conteudo

string nomeAluno = "Harry";
string nomeProfessor = "Minerva";
string carta_de_convite = $"Prezado sr/sra.{nomeAluno}\n" +
                        $"  Temos o prazer de informar que v.Sa {nomeAluno} tem uma vaga " +
                        $"na escola de Hogwarts. E Já anexamos uma lista de livros e " +
                        $"materiais necessários.\n" +
                        $"  O ano letivo começa no dia primeiro de setembro, estamos aguardando " +
                        $"sua coruja até 31 de julho,no mais tardar.\n" +
                        $"  Atenciosamente, " +
                        $"Prof. {nomeProfessor} " +
                        $"Diretor(a)."; 
//A interpolacao de String tbm pode ser usada para inserir variaveis dentro de uma string de forma a deixar mais legivel
//Basta colocar a variavel que quisermos entre colchetes {var} e pronto
//Outro recurso interessante eh utilizar $ para podermos escrever em linhas abaixo sem que haja quebra de linha propriamente dita na string
//Podemos utilizar o \n para a quebra de linha dentro de uma string
Console.WriteLine(carta_de_convite);


// o recurso \n eh chamado de caractere de escape, que sao sempre compostos de uma barra invertida( \ ) e um caractere
Console.WriteLine("Campainha: \a");  //Aciona um toque no Windows
Console.WriteLine("Aspas: \'");//Caso queiramos inserir aspas na string
Console.WriteLine("Aspas duplas: \"");
//Dentre outros

string diretorio = @"gabriel\nbarreto"; //Caso queiramos que o conteudo seja exatamente o que escrevemos, usamos o @ no inicio da string
Console.WriteLine(diretorio);

Console.WriteLine(diretorio.Length);    //Retorna o tamanho da string
string[] dividida = nomeCompleto.Split(" ");    //Passado um array de strings, podemos dividir uma string maior passando o caracter que indicara onde ela deve se dividir
Console.WriteLine(dividida[0]);
Console.WriteLine(dividida[1]);

Console.WriteLine("Primeira ocorrencia de [a] no meu nome: "+ nomeCompleto.IndexOf('a'));   //Indica em que posicao se encontra o caractere passado pela primeira vez
Console.WriteLine("Ultima ocorrencia de [a] no meu nome: " + nomeCompleto.LastIndexOf('a'));    //Indica em que posicao se encontra o caractere passado pela ultima vez

Console.WriteLine(nomeCompleto.Replace("Gabriel", "Joao Carlos"));  //Modifica o pedaco da string passado no primeiro argumento com o conteudo da segunda string
//Perceba que o conteudo de nomeCompleto nao eh modificado, uma string auxiliar eh criada, portanto, caso queiramos que isso fique salvo, devemos colocar em uma nova variavel

string palindromo = "ala";
string palavraInvertida = "ala";

if (palindromo.Equals(palavraInvertida))    //Compara o conteudo de duas strings e returna true se forem iguais
{
    Console.WriteLine("A palavra eh um Palindromo");
}
else
{
    Console.WriteLine("A palavra nao eh um Palindromo");
}