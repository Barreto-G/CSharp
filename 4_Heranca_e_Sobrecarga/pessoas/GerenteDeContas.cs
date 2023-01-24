
namespace _4_Heranca_e_Sobrecarga.pessoas
{
    public class GerenteDeContas: FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf, string rg, string nome, string login ,string senha) : base(cpf, rg, nome,login, senha)
        {
            this.Salario = 4000;
            this.Bonificacao = 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
