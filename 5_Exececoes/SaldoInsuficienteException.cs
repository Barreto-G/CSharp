using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Exececoes
{
    public class SaldoInsuficienteException : Exception  //Criando nossa propria excecao
    {
        public SaldoInsuficienteException() //os tres construtores padrao, uma boa pratica para a criacao de excessoes
        {

        }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception inner) : base(mensagem, inner) 
        { 

        }
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de movimentacao de " + valorSaque + " com saldo de " + saldo)  
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }   //Aqui, criamos um construtor personalizado para a excessao de sacar mais que o saldo disponivel 
            //Devemos chamar o construtor adequado que queiramos usar

    }
}
