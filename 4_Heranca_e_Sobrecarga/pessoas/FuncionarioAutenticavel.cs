using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Heranca_e_Sobrecarga.pessoas
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public FuncionarioAutenticavel(string cpf, string rg, string nome, string login,string senha) : base(cpf, rg, nome)
        {
            this.Login = login;
            this.Senha = senha;
        }

        public string Senha { get; set; }
        public string Login { get; set; }
       
        public bool Autenticar(string login, string senha)
        {
            return this.Login==login && this.Senha == senha;
        }

    }
}
