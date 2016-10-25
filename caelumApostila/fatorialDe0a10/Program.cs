using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fatorialDe0a10
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial;
            int numero;

            for (numero = 1; numero <= 10; numero++)
            {
                fatorial = 1;
                for (int i = numero ; i > 1; i--)
                {

                    fatorial *= i;

                }
                Console.WriteLine("Fatorial de " + numero + " = " + fatorial);
                
            }
            Console.ReadKey();

        }
    }
}
