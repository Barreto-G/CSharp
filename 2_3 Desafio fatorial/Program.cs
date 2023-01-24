using System;

    class Desafio
{
    static void Main()
    {
        for(int i =0; i<=10; i++)
        {
            int fatorial = 1;
            int cont = i;
            while (cont > 0)
            {
                fatorial = fatorial * cont;
                cont--;
            }
            Console.WriteLine(fatorial);
        }

        //Forma utilizada pelo professor:

        /*int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }*/

        //Realmente mais eficiente, utiliza a variavel fatorial para a proxima etapa em vez de refazer a conta sempre.
        //Do jeito que eu fiz, a complexidade de tempo do codigo tambem se torna fatorial.
    }
}