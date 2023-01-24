//Regex ou expressoes regulares sao formas de identificarmos padroes em Strings
//Para usa-las devemos chamar o namespace que os define

using System.Text.RegularExpressions;

Console.Write("Informe um valor:  ");
var caracteres = Console.ReadLine();

bool ok = Regex.IsMatch(caracteres, "^[0-9]+$");    //Essa Regex, por exemplo, verifica se o conteudo passado apresenta somente caracteres
if (!ok)                                            //A expressao eh uma String, devendo ser colocada entre aspas duplas
{
    Console.WriteLine("O valor informado não é um numérico válido.");
}
else
{
    Console.WriteLine("O valor informado é válido.");
}

Console.Write("Informe um cpf para validação: ");
var cpf = Console.ReadLine();

//Outra forma de declarar uma Regex eh instanciando um objeto da Classe Regex, passando a expressao regular para o construtor em forma de String
//Perceba o uso do @ para que ela seja passada exatamente como foi digitada
//Podemos tambem passar outras opcoes para o construtor, como no exemplo, passa-se a opcao que ignora letras maiusculas e minusculas do input

Regex regex = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnoreCase);   

//Nessa Regex temos duas expressoes regulares concatecnadas por |, que significa "ou"
//A primeira vai verificar o cpf passado sem os pontos enquanto a outra passara considerando os pontos, se pelo menos uma delas retornar true, o resultado eh verdadeiro
//os numeros entre [] indicam os valores possiveis ou o range de valores, [0-9] significa que qualquer valor de 0 a 9 eh valido
//Os valores entre colchetes {} indicam quantas vezes sera repetida a verificacao anterior
//O caractere ? na frente de [-] indica que ele eh opicional, podendo estar ou nao na string
//Perceba que inves de . devemos usar \. para inserirmos um ponto, como visto na Extra_Strings


var combinou = regex.Match(cpf);       //Funcao para verificar se uma string pertence ou nao a linguagem gerada pela expressao regular
//Perceba que eh utilizado um var para a variavel combinou, isso pq o retorno de Match eh um objeto com as informacoes sobre a analise

if (combinou.Success)                  //Retorna true se a verificacao foi bem sucedida
{
    Console.WriteLine("CPF no formato válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}

//Essa seria uma forma mais direta de fazer a comparacao se o objetivo for apenas validar ou nao uma entrada
//O retorno eh logo um valor booleano, nao sendo necessario criar um novo objeto para isso
if (regex.IsMatch(cpf))
{
    Console.WriteLine("CPF válido.");
}
else
{
    Console.WriteLine("CPF inválido.");
}