
namespace _4_Heranca_e_Sobrecarga.pessoas
{

	public class Diretor : FuncionarioAutenticavel
	{
		public Diretor(string cpf, string rg, string nome,string login, string senha): base(cpf, rg, nome, login ,senha)
		{
			this.Bonificacao = 0.5;
			this.Salario = 5000;
		}

        public override void AumentarSalario()
        {
			this.Salario *= 1.15;
        }

    }
}
