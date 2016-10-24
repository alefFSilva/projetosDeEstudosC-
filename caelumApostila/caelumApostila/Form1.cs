using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caelumApostila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Calcula Média 
        private void calculaMedia()
        {

            int idadeAlef = 23;
            int idadeRaissa = 22;
            int media = (idadeAlef + idadeRaissa) / 2;

            MessageBox.Show("Média das idades: " + media);

        }
        #endregion

        #region Hello World
        private void helloWorld() {

            MessageBox.Show("Hello World");

        }
        #endregion

        #region  Calcula Bhaskara

        private void calculaBhaskara()
        {

            int a = 2;
            int b = 4;
            int c = 4;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show(Convert.ToString(a1) + Convert.ToString(a2));

        }
        #endregion

        #region Verifica se pode votar

        private void verificaSePodeVotar()
        {

            int idade = 16;
            bool brasileiro = true;

            if(idade >= 16 && brasileiro)
            {

                MessageBox.Show("Pode votar !");

            }
            else
            {

                MessageBox.Show("Não pode votar !");

            }
        }

        #endregion

        #region Verificar o valor da NF e aplica Taxa

        public void verificaValorNF()
        {
            double valorNF = 5500.00;

            if (valorNF <= 999)
            {

                valorNF += valorNF * 0.02;

                MessageBox.Show("Valor da Nota com imposto: " + Convert.ToString(valorNF));

            }
            else if (valorNF <= 2999)
            {

                valorNF += valorNF * 0.025;

                MessageBox.Show("Valor da Nota com imposto: " + Convert.ToString(valorNF));
            }
            else if (valorNF <= 6999)
            {

                valorNF += valorNF * 0.028;

                MessageBox.Show("Valor da NOta com imposto: " + Convert.ToString(valorNF));
            }
            else {

                valorNF += valorNF * 0.03;

                MessageBox.Show("Valor da Nota com imposto: " + Convert.ToString(valorNF));

            }


        }

        #endregion

        #region Testa o laço FOR
        private void testaLacoFor()
        {
            int total =2;
            
            for(int i = 0; i< 5; i += 1)
            {
                total = total * 2;
            }

            MessageBox.Show("Total do incremento: " + total);


        }
        #endregion

        #region Eventos de botões

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            helloWorld();
        }

        private void btnMediaIdades_Click(object sender, EventArgs e)
        {
            calculaMedia();
        }

        private void btnBhaskara_Click(object sender, EventArgs e)
        {

            calculaBhaskara();

         }

      
        private void btnVerificaIdadeENacionalidade_Click(object sender, EventArgs e)
        {

            verificaSePodeVotar();

        }

        private void btnValorDaNF_Click(object sender, EventArgs e)
        {

            verificaValorNF();

        }

        private void btnLacoFor_Click(object sender, EventArgs e)
        {

            testaLacoFor();

        }
    }

    #endregion
}
