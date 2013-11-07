using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void evaluar_Click(object sender, EventArgs e)
        {

            string Sguerra = calendario.SelectionRange.Start.ToShortDateString();
            string nombre,codigo;
            int aciertos = 0;

            nombre = Convert.ToString(nomBox.Text);
            codigo = Convert.ToString(codBox.Text);


            if (gdl.Checked)
            {

            }
            else if (df.Checked)
            {
                aciertos++;
            }
            else if (mty.Checked) { 
            
            }






            if (portu.Checked) {
                aciertos--;
            }

            if (reino.Checked)
            {
                aciertos++;

            }
            if (mace.Checked)
            {
                aciertos++;

            }
            if (aus.Checked)
            {
                aciertos--;
            }
            if (chile.Checked)
            {
                aciertos++;
            }



            if (municipios.Value == 32)
            {

                aciertos++;

            }
            else aciertos--;


            if (Sguerra == "07/05/1945")
            {

                aciertos++;

            }


            MessageBox.Show("Codigo: " + codigo 
                            + "\n\nnombre: " + nombre + "\n\nAciertos: " + aciertos);   
            


            



        }
    }
}
