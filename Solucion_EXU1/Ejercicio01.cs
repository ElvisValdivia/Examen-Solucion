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
    public partial class Ejercicio01 : Form
    {
        double likert, nota, porcentaje;
        double valor;
        string criterio;
        public Ejercicio01()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            dtvResultado.Rows.Clear();

            for (int i = 0; i<=100;i++)
            {
                valor = i;
                //realizar conversiones 
                nota = Math.Round((valor * 20 / 100), 2);
                likert = Math.Round((valor * 5 / 100), 2);
                porcentaje= Math.Round(((valor * 100) /100),2);

                if ( nota >= 0&& nota <= 10)
                {
                    criterio = "No Logrado";

                }
                else if(nota > 10 && nota <= 14 )
                {
                    criterio = "Logro en Proceso";
                }
                else if (nota > 14 && nota <=17 )
                {
                    criterio = "Logrado";
                }
                else
                {
                    criterio = "Logrado con Exito";
                }
            }
        }
    }
}
