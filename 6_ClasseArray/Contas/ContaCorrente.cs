using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_OrientacaoAObjetos.Titular;    //Esse eh como se fosse o include, todos os arquivos dentro da pasta titular serao incluidos nesse codigo para utilizacao

namespace _3_OrientacaoAObjetos.Contas
{
    public class ContaCorrente : IComparable<ContaCorrente> //Permite implementarmos a comparacao entre os objetos da classe ContaCorrente
    {
        public static int NumContasCriadas; //Adicionando uma propriedade estatica, que pertence a classe e nao a cada objeto criado
                                            //Assim, nao usamos o this ao referenciar uma propriedade estatica dentro de uma classe 
                                            //da mesma forma, fora dela, usamos o nome da classe como referencia e nao o nome do objeto
        
        public ContaCorrente(int num_agen, Cliente Titula, string cont)
        {
            this.Saldo = 0;
            this.Num_agencia = num_agen;
            this.Titular = Titula;
            this.Conta = cont;
            NumContasCriadas++;
        }
        
        public int Num_agencia{ get; private set; }

        public string Conta{ get; private set; }
        
        public Cliente Titular { get; private set; }

        public double Saldo { get; private set; }

        public int CompareTo(ContaCorrente? other)  //Esse eh o metodo que permite que os objetos da classe possam ser comparados entre si
        {                                           //A interrogacao quer dizer que o parametro pode receber um objeto nulo
            if(other == null)
            {
                return 1;
            }
            else
            {
                return this.Num_agencia.CompareTo(other.Num_agencia); //Implementamos a comparacao entre os valores da agencia, para que seja ordenado em relacao a ela
            }                                                         //O compareTo apos o num_Agencia na vdd eh o metodo da classe int, que usamos como parametro para comparacao das contas
        }   
        /*A comparacao funciona da seguinte forma: retorno<0 quer dizer que esse objeto precede o parametro passado,
                                                   >0 quer dizer que esse objeto antecede o parametro, 
                                                   e 0 quer dizer que os dois objetos sao iguais*/

        public void deposito(double valor)
        { Saldo += valor; }

        public bool sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else { return false; }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (valor > Saldo)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }

        public override string ToString()   //Aqui, sobrescrevemos o metodo toString da classe base Object para que, quando o utilizemos, imprima todas as informacoes dessa conta
        {
            return $" === DADOS DA CONTA === \n" +
                    $"Número da Conta : {this.Conta} \n" +
                    $"Número da Agência : {this.Num_agencia} \n" +
                    $"Saldo da Conta: {this.Saldo} \n" +
                    $"Titular da Conta: {this.Titular.Nome} \n" +
                    $"CPF do Titular  : {this.Titular.Cpf} \n" +
                    $"Profissão do Titular: {this.Titular.Profissao}\n\n";
        }





    }
}
