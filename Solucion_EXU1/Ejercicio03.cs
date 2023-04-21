using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Solucion_EXU1
{
    public partial class Ejercicio03 : Form
    {
        public Ejercicio03()
        {
            InitializeComponent();
        }

        private void bwProgreso_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <=100, i++)
            {
                bwProgreso.ReportProgress(i);
                Thread.Sleep(100);

            }
        }

        private void bwProgreso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 20)
            {
                lblMensa.ForeColor = Color.Black;
                lblMensa.Text = string.Format("progreso ...{0} %", e.ProgressPercentage);
            }
            else if (e.ProgressPercentage >= 0 && e.ProgressPercentage <= 50)
            {
                lblMensa.ForeColor = Color.Yellow;
                lblMensa.Text = string.Format("progreso ...{0} %", e.ProgressPercentage);
            }
            else if (e.ProgressPercentage >= 0 && e.ProgressPercentage >= 70)
            {
                lblMensa.ForeColor = Color.Green;
                lblMensa.Text = string.Format("progreso ...{0} %", e.ProgressPercentage);
            }
            else
            {
                lblMensa.ForeColor = Color.Blue;
                lblMensa.Text = string.Format("progreso ...{0} %", e.ProgressPercentage);
            }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
