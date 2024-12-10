namespace EDDemo.M._Ordenamiento.M._interno
{
    partial class FrmShellsort
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
            this.lblDesordenado = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Enumerador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Enumerador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesordenado
            // 
            this.lblDesordenado.AutoSize = true;
            this.lblDesordenado.Location = new System.Drawing.Point(183, 72);
            this.lblDesordenado.Name = "lblDesordenado";
            this.lblDesordenado.Size = new System.Drawing.Size(138, 16);
            this.lblDesordenado.TabIndex = 0;
            this.lblDesordenado.Text = "Arreglo Desordenado";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(183, 110);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(118, 16);
            this.lblOrdenado.TabIndex = 1;
            this.lblOrdenado.Text = " Arreglo Ordenado";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(186, 165);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(104, 45);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Enumerador
            // 
            this.Enumerador.Location = new System.Drawing.Point(325, 177);
            this.Enumerador.Name = "Enumerador";
            this.Enumerador.Size = new System.Drawing.Size(56, 22);
            this.Enumerador.TabIndex = 3;
            // 
            // FrmShellsort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enumerador);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblDesordenado);
            this.Name = "FrmShellsort";
            this.Text = "FrmShellsort";
            this.Load += new System.EventHandler(this.FrmShellsort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enumerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesordenado;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown Enumerador;
    }
}