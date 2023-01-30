using _3_OrientacaoAObjetos.Contas;
using _6_ClasseArray;
using System.Collections;

//A classe Array eh a classe base para todos os outros arrays que foram vistos em 1_Variaveis

//Declaracao de um objeto Array


Array vetor = Array.CreateInstance(typeof(double), 5);
//Setando os valores no Array
vetor.SetValue(3.1, 0);
vetor.SetValue(4.2, 1);
vetor.SetValue(1.3, 2);
vetor.SetValue(2.4, 3);
vetor.SetValue(8.5, 4);
int pos = 0;

foreach(double i in vetor)  //metodo parecido com o for, que percorre todo o array, note que i ja recebe o valor do elemento do array,
{                           //portanto, caso a posicao do mesmo seja importante, usar o for pode ser melhor
    Console.WriteLine($"Elemento {pos} com valor {i}");
    pos++;
}
TestaMediana(vetor);

void TestaMediana(Array array)
{
    if(array == null || array.Length == 0)
    {
        Console.WriteLine("Array nulo ou sem elementos");
        return;
    }
    else
    {
        double[] copia = (double[])array.Clone();   //Criando uma copia do Array, devemos explicitar a conversao para um array do tipo double, ja que o retorno do metodo Clone eh um Object
        Array.Sort(copia);  //Metodo da classe Array que ordena os elementos do Array passado na declaracao
        double mediana = copia[copia.Length / 2];
        Console.WriteLine($"Mediana do vetor eh: {mediana}");

    }
}

ContaCorrente[] contas = new ContaCorrente[5];  //Podemos criar Arrays de Objetos das nossas proprias classes tambem
contas[0] = new ContaCorrente(69, new _3_OrientacaoAObjetos.Titular.Cliente("05", "08"), "54"); //Devemos declarar cada componente de cada posicao do array, ou ele retornara nulo naquela posicao
contas[1] = new ContaCorrente(73, new _3_OrientacaoAObjetos.Titular.Cliente("07", "08"), "69");
contas[2] = new ContaCorrente(57, new _3_OrientacaoAObjetos.Titular.Cliente("01", "08"), "24");

contas[2].deposito(100);

//Para "remover" um item do array, podemos simplesmente deixar o indice do item como null
contas[0] = null;

foreach (ContaCorrente ex in contas)
{
    if(ex == null)
    {
        Console.WriteLine("Referencia nula");
    }
    else
    {
        Console.WriteLine($"Numero da conta: {ex.Conta}");
    }
    
}

//A classe Array tem tamanho estatico, ou seja, o tamanho maximo do array eh o especificado na declaracao do mesmo
//A classe List<Type> funciona igual o Array, porem tem alocacao dinamica, similar ao vector em C++
//Tambem existe a Classe ArrayList que vem com as opcoes de adicionar e remover itens da lista

ArrayList _Contas = new ArrayList();
_Contas.Add(contas[0]); //Adiciona um item na lista
_Contas.Add(contas[1]);
_Contas.Add(contas[2]);
//_Contas.Add(74); //Perceba que esse Array list nao tem um tipo definido, ou seja, podemos adicionar qualquer coisa a ele, desde inteiros a strings
                   //Isso poderia causar varios tipos de excessao, portanto, deve-se ficar atento a sua utilizacao

//_Contas.RemoveAt(0);    //Remove o item da lista

Console.WriteLine();
foreach (ContaCorrente ex in _Contas)
{
    if (ex == null)
    {
        Console.WriteLine("Referencia nula");
    }
    else
    {
        Console.WriteLine($"Numero da conta: {ex.Conta}");
    }

}

List<ContaCorrente> _ListaContas = new List<ContaCorrente>();   //O objeto List funciona como um vetor no qual restringimos os tipos de dados para
                                                                //o tipo passado no momento de sua criacao, impedindo que casos como o da linha 77 acontecam
_ListaContas.Add(contas[0]);    //Tem as mesmas funcoes de ArrayList, porem restringindo o tipo dos dados, realmente funcionando como um Vector no C++
_ListaContas.Add(contas[1]);
_ListaContas.Add(contas[2]);

foreach (ContaCorrente ex in _ListaContas)
{
    if (ex == null)
    {
        Console.WriteLine("Referencia nula");
    }
    else
    {
        Console.WriteLine(ex.ToString() + "\n");  //Exibe os dados da conta por meio da sobrescrita feita na classe
    }

}
//A classe list eh uma classe generica, ou seja, funciona recebendo qualquer tipo de dados com a qual eh criada
//tambem podemos criar nossas proprias classes genericas da seguinte forma:

Generica<int> GenericaInteira = new Generica<int>();
GenericaInteira.MostrarMensagem(10);

Generica<string> GenericaString = new Generica<string>();
GenericaString.MostrarMensagem("10");


/*Voltando as propriedades de List, temos varios metodos que podemos usar
 .AddRange vai adicionar o conteudo de uma lista do mesmo tipo ao final da lista que chamou o metodo

 .GetRange permite criar uma sublista com os termos no range especificado, por exemplo
    var range = _ListaContas.GetRange(0,2); O retorno desse metodo eh uma lista de mesmo tipo com os termos de 0 a 2 da lista base

 .Count retorna um inteiro com o numero de termos na lista

 .Reverse() vai inveter a ordem dos elementos na lista

 .Clear() vai limpar todos os elementos da lista

 .Sort() ordena a lista caso o tipo de dados tenha um valor ordenavel 
    Para que uma lista seja comparavel, a classe de que ela eh composta precisa herdar a interface IComparable, implementado em ContaCorrente*/

Console.Clear();    //Funcao que limpa os dados do console
foreach (ContaCorrente ex in _ListaContas)
{
    if (ex != null)
    {
        Console.WriteLine(ex.ToString() + "\n");
    }

}
_ListaContas.Sort();

Console.WriteLine("Contas Ordenadas de acordo com a Agencia");

foreach (ContaCorrente ex in _ListaContas)
{
    if (ex != null)
    {
        Console.WriteLine(ex.ToString() + "\n");
    }

}
//Assim, ordenamos os elementos de _ListaContas de acordo com o numero de sua agencia

Console.Clear();
// .Where nos permite fazer pesquisas dentro da lista de acordo com o parametro passado
List<string> fruits =
    new List<string> { "apple", "passionfruit", "banana", "mango",
                    "orange", "blueberry", "grape", "strawberry" };

IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);    //Retorna uma lista enumeravel com os componentes que satisfazem a expressao
string fruta = fruits.Where(fruit => fruit.Length > 6).First(); //Retorna um unico elemento(o primeiro a ser encontrado) cujo comprimento seja maior que 6

foreach (string fruit in query)
{
    Console.WriteLine(fruit);
}

Console.WriteLine("\n"+ fruta);

Console.ReadLine();
Console.Clear();

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

Console.WriteLine(nomesDosEscolhidos.Contains("Anakin Wayne")); //A funcao Contais() retorna um bool que sera verdadeiro caso a lista contenha um elemento
                                                                //De mesmo valor/conteudo do passado como parametro

SortedList<int, string> times = new SortedList<int, string>();  //SortedList eh um tipo de lista que ja fica ordenada de acordo com um conjunto chave-valor
times.Add(0, "Flamengo");
times.Add(1, "Santos");
times.Add(2, "Juventus");

foreach (var item in times.Values)
{
    Console.WriteLine(item);
}

Stack<string> minhlaPilhaDeLivros = new Stack<string>();        //Tambem temos uma lista que implementa o conceito de Pilha, no qual o elemento do topo eh o ultimo adicionado
minhlaPilhaDeLivros.Push("Harry Porter e a Ordem da Fênix");    //Push adiciona um item a pilha, Pop retira o elemento do topo e Peek retorna o valor no topo
minhlaPilhaDeLivros.Push("A Guerra do Velho.");
minhlaPilhaDeLivros.Push("Protocolo Bluehand");
minhlaPilhaDeLivros.Push("Crise nas Infinitas Terras.");
minhlaPilhaDeLivros.Pop();

foreach (var item in minhlaPilhaDeLivros)
{
    Console.WriteLine(item);
}

Queue<string> filaAtenndimento = new Queue<string>();   //Queue implementa o conceito de fila, no qual os valores sao adicionados ao fim da fila, 
filaAtenndimento.Enqueue("André Silva");                //e o primeiro a ser adicionado eh o primeiro a ser removido
filaAtenndimento.Enqueue("Lou Ferrigno");
filaAtenndimento.Enqueue("Gal Gadot");
filaAtenndimento.Dequeue(); //Dequeue retira o primeiro item da fila

