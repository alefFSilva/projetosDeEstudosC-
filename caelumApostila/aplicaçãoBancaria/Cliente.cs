using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicaçãoBancaria
{
    class Cliente
    {
        string nome;
        string rg;
        string cpf;
        string endereco;

        int idade;



        public Boolean EhMaiorDeIdade()
        {
            if(this.idade >= 18)
            {
                return true;
            }

            return false;

        }
    }
}
