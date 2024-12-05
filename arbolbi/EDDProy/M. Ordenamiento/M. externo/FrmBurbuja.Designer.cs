namespace EDDemo.M._Ordenamiento.M._externo
{
    partial class FrmBurbuja
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
            this.lblDesordendo = new System.Windows.Forms.Label();
            this.Enumerar = new System.Windows.Forms.NumericUpDown();
            this.lblOrdenado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Enumerar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(206, 169);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 52);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblDesordendo
            // 
            this.lblDesordendo.AutoSize = true;
            this.lblDesordendo.Location = new System.Drawing.Point(203, 62);
            this.lblDesordendo.Name = "lblDesordendo";
            this.lblDesordendo.Size = new System.Drawing.Size(138, 16);
            this.lblDesordendo.TabIndex = 2;
            this.lblDesordendo.Text = "Arreglo Desordenado";
            // 
            // Enumerar
            // 
            this.Enumerar.Location = new System.Drawing.Point(365, 185);
            this.Enumerar.Name = "Enumerar";
            this.Enumerar.Size = new System.Drawing.Size(64, 22);
            this.Enumerar.TabIndex = 3;
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(203, 113);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(115, 16);
            this.lblOrdenado.TabIndex = 4;
            this.lblOrdenado.Text = "Arreglo Ordenado";
            // 
            // FrmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.Enumerar);
            this.Controls.Add(this.lblDesordendo);
            this.Controls.Add(this.btnGenerar);
            this.Name = "FrmBurbuja";
            this.Text = "FrmBurbuja";
            this.Load += new System.EventHandler(this.FrmBurbuja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Enumerar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblDesordendo;
        private System.Windows.Forms.NumericUpDown Enumerar;
        private System.Windows.Forms.Label lblOrdenado;
    }
}