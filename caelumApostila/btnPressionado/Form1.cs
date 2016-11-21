using System;
using System.Windows.Forms;

namespace btnPressionado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                    


           
        }

        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            
           
           
        }


        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

            timer1.Enabled = true;
            timer1.Start();

        }


        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count += 1;
            tb1.Text = count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb1.Focus();
        }
    }
}
