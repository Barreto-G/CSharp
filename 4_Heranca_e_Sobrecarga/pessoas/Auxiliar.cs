
namespace _4_Heranca_e_Sobrecarga.pessoas
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, string rg, string nome) : base(cpf, rg, nome)
        {
            this.Salario = 2000;
            this.Bonificacao = 0.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

    }
}
