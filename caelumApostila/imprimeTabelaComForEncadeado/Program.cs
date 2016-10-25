using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimeTabelaComForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i<=10; i++)
            {
                for(int p = 1; p <=i; p++)
                {
                    Console.Write(p*i + " ");

                }
                Console.WriteLine(" ");

            }

            Console.ReadKey();

        }
    }
}
