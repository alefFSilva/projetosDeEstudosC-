using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaNum1a100SemMultDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            for(int i = 0; i<=100; i++)
            {

                if(i % 3 != 0){

                    numero += i;

                }

            }

            Console.WriteLine("Valor total: " + numero);
            Console.ReadKey();

        }
    }
}
