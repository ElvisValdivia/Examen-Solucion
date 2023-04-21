using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_EXU1
{
    public partial class btnLimpiar : Form
    {
        public btnLimpiar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            rbtnLikert.Checked = false;
            rbtnNota.Checked = false;
            rbtnPorcentaje = false; 

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbtnLikert.Checked==true) 
               
            {
            
                if (valor>= 0 && valor <=5)
                {
                    dgvResultado.Rows.Clear();
                    txtValor = Convert.ToDouble(txtValor.Text);

                    nota = Math.Round((valor * 20 / 5), 2);
                    likert = Math.Round((valor * 5 / 5), 2);
                    porcentaje = Math.Round(((valor * 100) / 5), 2);

                    if (likert >= 0 && likert <= 2.5)
                    {
                        criterio = "No logrado";
                        txtColor.BlackColor = Color.Red;

                    }
                    else if (Likert > 2.5 )
                }
                else
                {
                    MessageBox.Show("El valor debe estar en el"+ "rango de (0-5)...", "conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
