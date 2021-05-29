using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U5_AC
{
    public partial class Form1 : Form
    {
      
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] estruc = new int [5];
            int v = 0;
            
            for ( int x = 1; x < textBox1.Text.Length; x++)
            {
                string letras = textBox1.Text.Substring(x, 1);


                if(letras =="a")
                {
                    estruc[0]++;
                    v++;
                }

                if (letras == "e")
                {
                    estruc[1]++;
                    v++;
                }
                
                if (letras == "i")
                {
                    estruc[2]++;
                    v++;
                }

                if (letras == "o")
                {
                    estruc[3]++;
                    v++;
                }

                if (letras == "u")
                {
                    estruc[4]++;
                    v++;
                }
            }
            label2.Text = "La cantidad de vocales en el texto es  =  " + v;
            label3.Text = "La cantidad de vocales a en el texto es  = " + estruc[0];
            label4.Text = "La cantidad de vocales a en el texto es  = " + estruc[1];
            label5.Text = "La cantidad de vocales a en el texto es  = " + estruc[2];
            label6.Text = "La cantidad de vocales a en el texto es  = " + estruc[3];
            label7.Text = "La cantidad de vocales a en el texto es  = " + estruc[4];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
