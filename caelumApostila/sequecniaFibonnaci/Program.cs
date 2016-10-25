using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequenciaFibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0 1 1 2 3 5 8
            // a b c
            //   a b c

            int a = 0, b = 1, c = 0;

            for(int i = 0; i < 20; i++)
            {

                Console.WriteLine("Sequencia Fibonnaci: " + c);

                c = a + b;

                b = a;
                a = c;
               

                
            }

            Console.ReadKey();
        }
    }
}
