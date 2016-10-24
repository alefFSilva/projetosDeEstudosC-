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

        #endregion

    }
}
