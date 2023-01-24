using _4_Heranca_e_Sobrecarga.pessoas;

namespace _4_Heranca_e_Sobrecarga.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel func, string login,string senha)    //Passando uma interface como parametro nos permite usar quaisquer classe que as implemente na funcao, nao tendo acesso, porem, aos outros atributos e metodos da classe
        {
            if (func.Autenticar(login,senha)) 
            {
                Console.WriteLine("Bem vindo ao sistema ");
                return true; 
            }
            else 
            {
                Console.WriteLine("Senha Incorreta ou funcionario nao tem acesso ao sistema!");
                return false; 
            }
        }

    }
}
