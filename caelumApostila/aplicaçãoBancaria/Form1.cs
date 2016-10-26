using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicaçãoBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region primeiros exercícios
        private void realizaSaque()
        {
            double saldo = 100.0;
            double valorSaque = 10.0;

            if(saldo >= valorSaque)
            {

                saldo -= valorSaque;

                MessageBox.Show("Saque realizado com sucesso!");

            }
            else
            {

                MessageBox.Show("Saldo insulficiene!");

            }

        }

        private void realizaSaqueComTaxa()
        {
            double taxa;


        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            realizaSaque();
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.saldo = 100;
            c.titular = "alef";

            if (c.Saca(50))
            {

                MessageBox.Show("Saque realizado com sucesso!");

            }
            else
            {

                MessageBox.Show("Saldo insuficiente !");
            }

            MessageBox.Show("Saldo c: " + c.titular);

        }


    }
}
