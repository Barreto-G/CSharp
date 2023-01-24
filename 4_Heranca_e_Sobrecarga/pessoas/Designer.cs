
namespace _4_Heranca_e_Sobrecarga.pessoas
{
    public class Designer : Funcionario
    {
        public Designer(string cpf, string rg, string nome) : base(cpf, rg, nome)
        {
            this.Salario = 3000;
            this.Bonificacao = 0.17;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }
    }
}
