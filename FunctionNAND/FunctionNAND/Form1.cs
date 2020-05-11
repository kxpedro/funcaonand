using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionNAND
{
    public partial class Form1 : Form
    {
        int[] y  = new int[] { 0, 0, 0, 0 };
        int[] x1 = new int[] { 0, 0, 1, 1 };
        int[] x2 = new int[] { 0, 1, 0, 1 };
        int[] z  = new int[] { 1, 1, 1, 0 };
               
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int w1 = int.Parse(txtW1.Text);
            int w2 = int.Parse(txtW2.Text);
            int theta = int.Parse(txtLimiar.Text);

            int con = 1;

            while (con == 1)
            {
                var zin = (x1 * w1) + (x2 * w2);

                for (int i = 1; i < 4; i++)
                {
                    if (zin(i) >= theta)                    
                        y(i) = 1;
                    else
                        y(i) = 0;
                }

                //Saída da Rede
                //Display Y

                if (y == z)                
                    con = 0;
                else
                    //A rede não esta aprendendo. Entre com outro conjunto de valores para pesos e limiar
            }

        }
    }
}
