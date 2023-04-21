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
    public partial class Ejercicio04 : Form
    {
        public Ejercicio04()
        {
            InitializeComponent();
        }

        private void Ejercicio04_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables 
            int cantidad, caramelos;
            double precio, compra, descuento, pago;

            //entrada de datos

            precio = Double.Parse(txtPrecio.Text);
            cantidad = Convert.ToInt32(txtCantidad.Text);

            //calculo 

            compra = precio * cantidad;
            descuento = 0.11 * compra;
            pago = compra * descuento;
            caramelos = 2*cantidad;

            //impresion de resultados
            txtResultado.Text += "Importe de compra :" + compra + "\r\n" +
                                    "Importe de descuento :" + compra + "\r\n" +
                                    "Importe a pagar  :" + compra + "\r\n" +
                                    "Caramelos" + compra + caramelos;
        }
    }
}
