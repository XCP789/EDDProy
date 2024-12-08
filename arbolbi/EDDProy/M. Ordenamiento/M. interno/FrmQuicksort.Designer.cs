namespace EDDemo.M._Ordenamiento.M._interno
{
    partial class FrmQuicksort
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
            this.lblDesordenado = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.Numerador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(240, 206);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(112, 48);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblDesordenado
            // 
            this.lblDesordenado.AutoSize = true;
            this.lblDesordenado.Location = new System.Drawing.Point(190, 76);
            this.lblDesordenado.Name = "lblDesordenado";
            this.lblDesordenado.Size = new System.Drawing.Size(138, 16);
            this.lblDesordenado.TabIndex = 1;
            this.lblDesordenado.Text = "Arreglo Desordenado";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(190, 116);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(115, 16);
            this.lblOrdenado.TabIndex = 2;
            this.lblOrdenado.Text = "Arreglo Ordenado";
            // 
            // Numerador
            // 
            this.Numerador.Location = new System.Drawing.Point(378, 220);
            this.Numerador.Name = "Numerador";
            this.Numerador.Size = new System.Drawing.Size(50, 22);
            this.Numerador.TabIndex = 3;
            // 
            // FrmQuicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numerador);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblDesordenado);
            this.Controls.Add(this.btnGenerar);
            this.Name = "FrmQuicksort";
            this.Text = "FrmQuicksort";
            this.Load += new System.EventHandler(this.FrmQuicksort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDesordenado;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.NumericUpDown Numerador;
    }
}