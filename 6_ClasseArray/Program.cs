using _3_OrientacaoAObjetos.Contas;
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
contas[0] = new ContaCorrente(69, new _3_OrientacaoAObjetos.Titular.Cliente("07", "08"), "54"); //Devemos declarar cada componente de cada posicao do array, ou ele retornara nulo naquela posicao
contas[1] = new ContaCorrente(73, new _3_OrientacaoAObjetos.Titular.Cliente("07", "08"), "69");
contas[2] = new ContaCorrente(57, new _3_OrientacaoAObjetos.Titular.Cliente("07", "08"), "24");

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

_Contas.RemoveAt(0);    //Remove o item da lista

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
