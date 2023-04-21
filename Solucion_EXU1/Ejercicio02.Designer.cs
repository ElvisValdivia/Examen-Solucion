namespace Solucion_EXU1
{
    partial class btnLimpiar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbtnLikert = new System.Windows.Forms.RadioButton();
            this.rbtnPorcentaje = new System.Windows.Forms.RadioButton();
            this.rbtnNota = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.ColLiker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColLiker,
            this.ColPorcentaje,
            this.ColNota,
            this.ColCondicion});
            this.dgvResultado.Location = new System.Drawing.Point(101, 180);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(602, 69);
            this.dgvResultado.TabIndex = 4;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(418, 96);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese valor ";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(231, 99);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // rbtnLikert
            // 
            this.rbtnLikert.AutoSize = true;
            this.rbtnLikert.Location = new System.Drawing.Point(209, 157);
            this.rbtnLikert.Name = "rbtnLikert";
            this.rbtnLikert.Size = new System.Drawing.Size(69, 17);
            this.rbtnLikert.TabIndex = 8;
            this.rbtnLikert.TabStop = true;
            this.rbtnLikert.Text = "Liker(0-5)";
            this.rbtnLikert.UseVisualStyleBackColor = true;
            // 
            // rbtnPorcentaje
            // 
            this.rbtnPorcentaje.AutoSize = true;
            this.rbtnPorcentaje.Location = new System.Drawing.Point(329, 157);
            this.rbtnPorcentaje.Name = "rbtnPorcentaje";
            this.rbtnPorcentaje.Size = new System.Drawing.Size(109, 17);
            this.rbtnPorcentaje.TabIndex = 9;
            this.rbtnPorcentaje.TabStop = true;
            this.rbtnPorcentaje.Text = "Porcentaje(0-100)";
            this.rbtnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // rbtnNota
            // 
            this.rbtnNota.AutoSize = true;
            this.rbtnNota.Location = new System.Drawing.Point(485, 157);
            this.rbtnNota.Name = "rbtnNota";
            this.rbtnNota.Size = new System.Drawing.Size(75, 17);
            this.rbtnNota.TabIndex = 10;
            this.rbtnNota.TabStop = true;
            this.rbtnNota.Text = "Nota(0-20)";
            this.rbtnNota.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(579, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ColCondicion.HeaderText = "Criterio";
            this.ColCondicion.Name = "ColCondicion";
            this.ColCondicion.ReadOnly = true;
            this.ColCondicion.Width = 120;
            // 
            // btnLimpiar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnNota);
            this.Controls.Add(this.rbtnPorcentaje);
            this.Controls.Add(this.rbtnLikert);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeros);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnGenerar);
            this.Name = "btnLimpiar";
            this.Text = "Ejercicio02";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbtnLikert;
        private System.Windows.Forms.RadioButton rbtnPorcentaje;
        private System.Windows.Forms.RadioButton rbtnNota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLiker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPorcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCondicion;
    }
}