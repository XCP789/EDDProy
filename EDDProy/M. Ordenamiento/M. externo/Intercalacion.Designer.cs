namespace EDDemo.M._Ordenamiento.M._externo
{
    partial class Intercalacion
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
            this.Numerador = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesordenado
            // 
            this.lblDesordenado.AutoSize = true;
            this.lblDesordenado.Location = new System.Drawing.Point(262, 74);
            this.lblDesordenado.Name = "lblDesordenado";
            this.lblDesordenado.Size = new System.Drawing.Size(136, 16);
            this.lblDesordenado.TabIndex = 2;
            this.lblDesordenado.Text = "Arreglo desordenado";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(262, 125);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(113, 16);
            this.lblOrdenado.TabIndex = 3;
            this.lblOrdenado.Text = "Arreglo ordenado";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(265, 199);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 45);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Numerador
            // 
            this.Numerador.Location = new System.Drawing.Point(375, 214);
            this.Numerador.Name = "Numerador";
            this.Numerador.Size = new System.Drawing.Size(51, 22);
            this.Numerador.TabIndex = 5;
            // 
            // Intercalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Numerador);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblDesordenado);
            this.Name = "Intercalacion";
            this.Text = "Intercalacion";
            this.Load += new System.EventHandler(this.Intercalacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesordenado;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown Numerador;
    }
}