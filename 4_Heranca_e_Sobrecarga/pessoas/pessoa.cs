
namespace _4_Heranca_e_Sobrecarga.pessoas
{
	public abstract class Pessoa
	{
        public Pessoa(string cpf, string rg, string nome)
        {
            this.CPF = cpf;
            this.RG = rg;
			this.Nome = nome;
            this.Telefone = "";
            this.Endereco = "";
        }
        public string Nome { get; set; }
		public string CPF { get; private set; }
        public string RG { get; private set; }
		public string Endereco { get; set; }
		public string Telefone { get; set; }
    }
}