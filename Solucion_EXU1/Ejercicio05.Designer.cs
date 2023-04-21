namespace Solucion_EXU1
{
    partial class Ejercicio05
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLiker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(342, 57);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(120, 13);
            this.lblNumeros.TabIndex = 5;
            this.lblNumeros.Text = "Conversion de Numeros";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNro,
            this.ColLiker,
            this.ColPorcentaje,
            this.ColNota});
            this.dgvResultado.Location = new System.Drawing.Point(101, 180);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(599, 214);
            this.dgvResultado.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(362, 115);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Nro";
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            // 
            // ColLiker
            // 
            this.ColLiker.HeaderText = "Columna 1";
            this.ColLiker.Name = "ColLiker";
            this.ColLiker.ReadOnly = true;
            // 
            // ColPorcentaje
            // 
            this.ColPorcentaje.HeaderText = "Columna 2";
            this.ColPorcentaje.Name = "ColPorcentaje";
            this.ColPorcentaje.ReadOnly = true;
            // 
            // ColNota
            // 
            this.ColNota.HeaderText = "Columna 3";
            this.ColNota.Name = "ColNota";
            this.ColNota.ReadOnly = true;
            // 
            // Ejercicio05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnGenerar);
            this.Name = "Ejercicio05";
            this.Text = "Ejercicio05";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLiker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNota;
    }
}