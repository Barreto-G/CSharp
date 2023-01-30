using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ClasseArray
{
    public class Generica<T>
    {
        public void MostrarMensagem(T variavel)
        {
            Console.WriteLine($"Voce esta usando uma classe generica de tipo: {variavel.GetType()}");
        }
    }
}
