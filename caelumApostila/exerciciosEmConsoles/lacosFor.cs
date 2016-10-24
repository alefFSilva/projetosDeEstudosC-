using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosEmConsoles
{
    class lacosFor
    {

        public static void Main()
        {


            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0)
                {

                    Console.WriteLine("Número múltiplo de 3: " + i);

                }


            }

            Console.ReadKey();


        }


        #region Métodos
        private void lacoMultiploDeTres()
        {

            for (int i = 0; i <= 100; i++)
            {

                if (i % 3 == 0)
                {

                    Console.WriteLine("Número múltiplo de 3: " + i);

                }


            }

        }

        private void lacoAteMil()
        {

            for (int i = 0; i <= 1000; i++)
            {

                Console.WriteLine("Número: " + i);

            }
            Console.ReadKey();


        }

        #endregion
    }
}
