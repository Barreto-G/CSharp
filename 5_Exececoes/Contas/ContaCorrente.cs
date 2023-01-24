using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using _5_Excecoes.Titular;    //Esse eh como se fosse o include, todos os arquivos dentro da pasta titular serao incluidos nesse codigo para utilizacao
using _5_Exececoes;

namespace _5_Excecoes.Contas
{
    public class ContaCorrente
    {
        public static int NumContasCriadas; //Adicionando uma propriedade estatica, que pertence a classe e nao a cada objeto criado
                                            //Assim, nao usamos o this ao referenciar uma propriedade estatica dentro de uma classe 
                                            //da mesma forma, fora dela, usamos o nome da classe como referencia e nao o nome do objeto
        public static double TaxaOperacao { get; private set; }
        
        public ContaCorrente(int num_agen, Cliente Titula, string num_conta)
        {
            this.Saldo = 0;

            if (num_agen <= 0)
            {                                                                           //nameof(variavel) retorna uma string com o nome da variavel
                throw new ArgumentException("Numero da agencia menor ou igual a zero", nameof(num_agen)); //Caso encontre a funcao throw, a execucao acha o bloco catch com o tipo de excecao equivalente e o executa
            }                                                       //O primeiro parametro eh a mensagem gerada pela excecao e o segundo o nome do parametro que a gerou
            
            if(!Regex.IsMatch(num_conta, @"[0-9]{3}[-][A-Z]{1}"))
            {
                throw new ArgumentException("Numero da conta fora do padrao, o padrao eh 000-A", nameof(num_conta));    //Verifica se o CPF esta padronizado
            }

            this.Num_agencia = num_agen;
            this.Conta = num_conta;
            this.Titular = Titula;
            
            NumContasCriadas++; 

            try                                         //O bloco try esta sempre ligado ao catch, no try, tentamos executar uma operacao que pode gerar uma excessao
            {                                           //Ja o bloco catch, recebe como argumento a excessao que pode ser gerada e contem em seu bloco os comandos necessarios para contorna-la
                TaxaOperacao = 30 / NumContasCriadas;   //Caso ainda nao haja uma conta criada no projeto, o compilador retorna a excecao "Divisao por zero"
                                                        //Para contornar esse problema, devemos aplicar um tratamento para essa excessao
            }
            catch(DivideByZeroException)
            {
                TaxaOperacao = 30;
            }
            
                                
        }
        
        public int Num_agencia{ get; private set; }

        public string Conta{ get; private set; }
        
        public Cliente Titular { get; private set; }

        public double Saldo { get; private set; }

        public void deposito(double valor)
        { Saldo += valor; }

        public bool sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else { throw new SaldoInsuficienteException(Saldo, valor); }
        }

        public bool transferir(double valor, ContaCorrente destino)
        {
            if (valor > Saldo)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                Saldo -= valor;
                destino.deposito(valor);
                return true;
            }
        }






    }
}
