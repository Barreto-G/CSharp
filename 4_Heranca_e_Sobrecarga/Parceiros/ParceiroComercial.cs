using _4_Heranca_e_Sobrecarga.pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Heranca_e_Sobrecarga.Parceiros
{
    public class ParceiroComercial : IAutenticavel
    {
        public ParceiroComercial(string login,string senha)
        {
            Senha = senha;
            Login = login;
        }
        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;  
        }
    }
}
