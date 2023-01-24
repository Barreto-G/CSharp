
namespace _4_Heranca_e_Sobrecarga.pessoas
{
	public abstract class Funcionario : Pessoa	//Tornando funcionario uma classe abstrata, impedimos a instanciacao de objetos do tipo funcionario, permitindo apenas as classes derivadas
	{
        public Funcionario(string cpf, string rg, string nome) : base(cpf, rg, nome)  //utilizamos a palavra-chave base para passar os parametros do construtor da classe base
        {
            TotalDeFuncionario++;
        }


		public double Salario { get; protected set; }
		public double Bonificacao { get; protected set; }
		public static int TotalDeFuncionario { get; protected set; }

		//Para realizarmos sobrescrita de classes, devemos assinalar na classe base que o metodo em questao pode ser sobrescrito
		//para isso, utiliza-se a palavra chave "virtual"
		//ex: public virtual double func(){}
		//Entao, na classe derivada, utilizamos a palavra override para indicar ao compilador que ele deve sobrescrever o metodo virtual da classe base
		// public override double func(){}

		//A palavra chave base permite acessarmos metodos da classe base diretamente, 
		//podendo ser usada para chamar um metodo da classe base que foi sobrescrito na classe derivada
		//Por exemplo, se quisermos chamar func() da classe base na func() da classe derivada, basta fazer:
		//base.func(); dentro do escopo da funcao

		public abstract void AumentarSalario();	//Definindo um metodo como abstrato, obrigamos as classes bases a implementar um metodo sobrescrito de mesmo nome

		public double CalcularBonificacao()
		{
			return this.Bonificacao * this.Salario;
		}

        public override string ToString()	//Aqui fizemos um override da funcao toString da classe Object, a classe base para qualquer classe que criamos no C#
        {
			return $"Nome: {this.Nome},\n" +
					$"CPF: {this.CPF},\n" +
					$"RG: {this.RG},\n" +
					$"Salario: {this.Salario}";
        }


    }

}

//Perceba que ha diferenca entre declarar um metodo como virtual e como abstrato
//O virtual permite que o metodo seja sobrescrito por uma classe derivada
//O abstrato exige que a classe derivada implemente um metodo que o sobrescreva