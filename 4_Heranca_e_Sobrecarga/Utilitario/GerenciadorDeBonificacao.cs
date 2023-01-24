using _4_Heranca_e_Sobrecarga.pessoas;

namespace _4_Heranca_e_Sobrecarga.Utilitario
{
	public class GerenciadorDeBonificacao
	{ 

		public double TotalBonificacao { get; private set; }

		public void Registrar(Funcionario funcionario)
		{
			this.TotalBonificacao += (funcionario.Bonificacao*funcionario.Salario);
		}


	}
}

