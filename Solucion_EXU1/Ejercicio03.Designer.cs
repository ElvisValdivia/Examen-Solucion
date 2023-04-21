namespace Solucion_EXU1
{
    partial class Ejercicio03
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pgbRecorrido = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblMensa = new System.Windows.Forms.Label();
            this.bwProgreso = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(278, 162);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 1;
            // 
            // pgbRecorrido
            // 
            this.pgbRecorrido.Location = new System.Drawing.Point(152, 203);
            this.pgbRecorrido.Name = "pgbRecorrido";
            this.pgbRecorrido.Size = new System.Drawing.Size(269, 20);
            this.pgbRecorrido.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(268, 86);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblMensa
            // 
            this.lblMensa.AutoSize = true;
            this.lblMensa.Location = new System.Drawing.Point(285, 161);
            this.lblMensa.Name = "lblMensa";
            this.lblMensa.Size = new System.Drawing.Size(35, 13);
            this.lblMensa.TabIndex = 4;
            this.lblMensa.Text = "label1";
            // 
            // bwProgreso
            // 
            this.bwProgreso.WorkerReportsProgress = true;
            this.bwProgreso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwProgreso_DoWork);
            this.bwProgreso.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwProgreso_ProgressChanged);
            // 
            // Ejercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensa);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pgbRecorrido);
            this.Controls.Add(this.lblMensaje);
            this.Name = "Ejercicio03";
            this.Text = "Ejercicio03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox pgbRecorrido;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblMensa;
        private System.ComponentModel.BackgroundWorker bwProgreso;
    }
}