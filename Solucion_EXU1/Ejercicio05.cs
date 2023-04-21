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
    public partial class Ejercicio05 : Form
    {
        public Ejercicio05()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dgvResultado.Rows.Clear();

            // declarar variables

            int columna1 = 5, columna2 = 12, columna3 = 18;
            int numero = 1;

            // generar tabla 

            for (int i = 0; i < 7; i++)
            {
                dgvResultado.Rows.Add(i, columna1, columna2, columna3);
                //pase a la siguiente fila 

                columna1 += 5;
                columna2 -= 2;
                columna3 -= 3;
            }
        }
    }
}
