using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroDivisiveisPor3Ou4Entre0e30_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
        

            for (int i = 1; i <= 30; i++) {
                if (i % 3 == 0) {

                    Console.WriteLine("Divisível por 3: " + i);

                }
                else if( i % 4 == 0) 
                {
                    Console.WriteLine("Divisível por 4: " + i);

                }
            }
            Console.ReadKey();

        }
    }
}
