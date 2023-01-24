using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Heranca_e_Sobrecarga.pessoas
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }   //Toda classe que assina a interface deve implementar ate as variaveis contidas nela
        public string Login { get; set; }

        public bool Autenticar(string login, string senha);   //Variavel que vamos obrigar as classes herdeiras a implementar

    }
}

//Uma interface funciona como um contrato, obrigando a quem herda implementar quaisquer metodos que tenham sido declarados nela
//No entanto, ela nao eh uma classe, portanto nao ha instanciacao de objetos dela, somente sendo usada para criar esses "contratos" para outras classes herdarem.
//Se trata de uma solucao para o problema de nao existir heranca multipla em C#
//Saiba que eh possivel para uma classe herdar mais de uma interface, simulando uma heranca multipla