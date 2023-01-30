using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_OrientacaoAObjetos.Titular;    //Esse eh como se fosse o include, todos os arquivos dentro da pasta titular serao incluidos nesse codigo para utilizacao

namespace _3_OrientacaoAObjetos.Contas
{
    public class ContaCorrente
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

        /*public void SetSaldo(double valor)
        {
            if (valor < 0) 
                { return; }
            else 
                { this.saldo= valor; }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }*/






    }
}
