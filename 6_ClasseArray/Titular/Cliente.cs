using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_OrientacaoAObjetos.Titular
{
    public class Cliente
    {
        public Cliente(string r, string c) 
        { 
            this.Rg = r; 
            this.Cpf = c; 
        }    

        private string nome;
        public string Nome      //implementando os gets e sets por meio de uma propriedade, um modo de encapsular variaveis privadas de forma mais organizada. 
        {                       //Sao publicas por definicao e sempre comecam com letra maiuscula
            get { return nome; }
            set {
                  if (value != null)    //Value eh o valor passado pelo usuario ao chamar a funcao set
                    { nome = value; } 
                }
        }

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        //private string profissao = "";
        public string Profissao {get; set;} //Caso queira encapsular uma propriedade sem fazer nenhum tipo de verificacao, eh possivel apenas declarar a propriedade.
                                            //Nesse caso, nao precisamos da variavel declarada anteriormente, pois o proprio compilador cria uma variavel privada para utilizacao.
    }
}
