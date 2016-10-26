using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicaçãoBancaria
{
    class Conta
    {
      public  int numero;
      public  string titular;
      public  double saldo;
        public int idade;


      public void Deposita(double valor)
    {
            this.saldo += valor;
    }

        public Boolean Saca(double valor)
        {

            if (this.saldo >= valor)
            {
                if (this.idade >= 18 && valor > 200)
                {

                    this.saldo -= 200;

                    return true;
                }
                else
                {

                    this.saldo -= valor;

                    return true;
                }


            }

            return false;
        }

    }

   
}
