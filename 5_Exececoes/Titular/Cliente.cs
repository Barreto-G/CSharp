using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5_Excecoes.Titular
{
    public class Cliente
    {
        public Cliente(string rg, string cpf, string nome="", string profissao = "") 
        {
            this.Nome = nome;
            this.Rg = rg; //Como rg nao tem um padrao ao redor do brasil, nao sei ainda como verificar a validade dele
            if(!Regex.IsMatch(cpf, @"([0-9]{9}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})"))
            {
                throw new ArgumentException("CPF digitado eh invalido", nameof(cpf));
            }
            this.Cpf = cpf;
            this.Profissao = profissao;
        }    

        public string Nome      //implementando os gets e sets por meio de uma propriedade, um modo de encapsular variaveis privadas de forma mais organizada. 
        {                       //Sao publicas por definicao e sempre comecam com letra maiuscula
            get;
            set;
        }

        public string Cpf { get; private set; }

        public string Rg { get; private set; }

        //private string profissao = "";
        public string Profissao {get; set;} //Caso queira encapsular uma propriedade sem fazer nenhum tipo de verificacao, eh possivel apenas declarar a propriedade.
                                            //Nesse caso, nao precisamos da variavel declarada anteriormente, pois o proprio compilador cria uma variavel privada para utilizacao.
    }
}
