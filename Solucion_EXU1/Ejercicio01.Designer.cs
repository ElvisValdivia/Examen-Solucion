namespace Solucion_EXU1
{
    partial class Ejercicio01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtvResultado = new System.Windows.Forms.DataGridView();
            this.lblNumeros = new System.Windows.Forms.Label();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLiker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(354, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtvResultado
            // 
            this.dtvResultado.AllowUserToAddRows = false;
            this.dtvResultado.AllowUserToDeleteRows = false;
            this.dtvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNro,
            this.ColLiker,
            this.ColPorcentaje,
            this.ColNota,
            this.ColCondicion});
            this.dtvResultado.Location = new System.Drawing.Point(93, 180);
            this.dtvResultado.Name = "dtvResultado";
            this.dtvResultado.ReadOnly = true;
            this.dtvResultado.Size = new System.Drawing.Size(599, 214);
            this.dtvResultado.TabIndex = 1;
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(334, 57);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(120, 13);
            this.lblNumeros.TabIndex = 2;
            this.lblNumeros.Text = "Conversion de Numeros";
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Nro";
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            // 
            // ColLiker
            // 
            this.ColLiker.HeaderText = "Liker(0-5)";
            this.ColLiker.Name = "ColLiker";
            this.ColLiker.ReadOnly = true;
            // 
            // ColPorcentaje
            // 
            this.ColPorcentaje.HeaderText = "Porcentaje(0-100)";
            this.ColPorcentaje.Name = "ColPorcentaje";
            this.ColPorcentaje.ReadOnly = true;
            // 
            // ColNota
            // 
            this.ColNota.HeaderText = "Nota(0-20)";
            this.ColNota.Name = "ColNota";
            this.ColNota.ReadOnly = true;
            // 
            // ColCondicion
            // 
            this.ColCondicion.HeaderText = "Condicion";
            this.ColCondicion.Name = "ColCondicion";
            this.ColCondicion.ReadOnly = true;
            this.ColCondicion.Width = 120;
            // 
            // Ejercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.dtvResultado);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Ejercicio01";
            this.Text = "Ejercicio01";
            ((System.ComponentModel.ISupportInitialize)(this.dtvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dtvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLiker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCondicion;
        private System.Windows.Forms.Label lblNumeros;
    }
}