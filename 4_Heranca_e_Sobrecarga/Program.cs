using _4_Heranca_e_Sobrecarga.pessoas;
using _4_Heranca_e_Sobrecarga.Utilitario;
using _4_Heranca_e_Sobrecarga.SistemaInterno;
using _4_Heranca_e_Sobrecarga.Parceiros;

class program
{
    static void BoasVindas(Funcionario func, GerenciadorDeBonificacao gerente)
    {
        Console.WriteLine("Novo funcionario cadastrado: " + func.Nome + " com salario: " + func.Salario);
        Console.WriteLine("Com Bonificacao mensal de: " + func.CalcularBonificacao());
        /*func.AumentarSalario();
        Console.WriteLine("Salario aumentado para: "+func.Salario);
        Console.WriteLine();*/
        gerente.Registrar(func);
    }

    static void Main(string[] args)
    {
        GerenciadorDeBonificacao gerente = new GerenciadorDeBonificacao();

        Diretor diretor = new Diretor("001","01","Gabriel","barreto", "2001");
        BoasVindas(diretor,gerente);

        Designer designer = new Designer("003", "03", "Laura");
        BoasVindas(designer, gerente);

        GerenteDeContas gerentedecontas = new GerenteDeContas("004", "04", "Brunoro","gabriel", "2002");
        BoasVindas(gerentedecontas, gerente);

        Auxiliar auxiliar = new Auxiliar("005", "05", "Flavio");
        BoasVindas(auxiliar, gerente);

        Console.WriteLine(Funcionario.TotalDeFuncionario);
        Console.WriteLine(gerente.TotalBonificacao);

        SistemaInterno autenticacao = new SistemaInterno();
        autenticacao.Logar(diretor,"barret" ,"2001");
        autenticacao.Logar(gerentedecontas,"gabriel", "2002");


        ParceiroComercial parca = new ParceiroComercial("duda", "123");
        autenticacao.Logar(parca, "Duda", "123");

        Console.WriteLine(diretor.ToString());

    }
}