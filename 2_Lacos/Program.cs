using System;

class program{
    static void Main(string[] args){
        //
        int idade = 1;

        while (true)    //Tambem utilizado da mesma forma que em C
        {
            Console.Write("Digite sua idade ou 0 para cancelar: ");
            idade = Int32.Parse(Console.ReadLine()); //Tratamento de excessoes requerido
                                                     //essa eh uma forma de pegar um inteiro de uma linha usando o Console.ReadLine
            if (idade == 0) { break; }

            //o laco if funciona exatamente igual em C e C++
            if (idade >= 18 && true)  //Os operadores && e || sao utilizados assim como em C, sendo o primeiro para AND e o segundo para OR
            {
                Console.WriteLine("Pode entrar, sua idade eh " + idade);
            }
            else { Console.WriteLine("Voce ainda eh muito novo, sua idade eh " + idade); }

        }
        //Eh importante ressaltar que, em C#, variaveis booleanas sao apenas true ou false, nao podendo ser utilizado 0 e 1, que sao lidos apenas como inteiros pelo compilador.
        //Comandos if, else if, else, switch, while e lacos de loop em geral sao iguais ao C.

        double investimento = 1000.00;
        double rendimento = 0.5 / 100;
        int mes = 0;

        for (mes=1; mes<=12;mes++)  //Laco for igual C
        {
            investimento = investimento + investimento * rendimento;
            Console.WriteLine("No mes "+mes+" voce tera R$ "+investimento);
        }

        //No laco Do-While, o bloco eh executado e depois a verificacao eh feita, ao contrario dos outros loops onde a condicao eh verificada antes da execucao do codigo



    }
}
