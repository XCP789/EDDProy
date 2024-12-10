namespace EDDemo.M._Busqueda
{
    partial class FrmBqHASH
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
            this.Numerador2 = new System.Windows.Forms.NumericUpDown();
            this.Numerador = new System.Windows.Forms.NumericUpDown();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblArreglo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(200, 153);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 45);
            this.btnGenerar.TabIndex = 20;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Numerador2
            // 
            this.Numerador2.Location = new System.Drawing.Point(327, 165);
            this.Numerador2.Name = "Numerador2";
            this.Numerador2.Size = new System.Drawing.Size(51, 22);
            this.Numerador2.TabIndex = 19;
            // 
            // Numerador
            // 
            this.Numerador.Location = new System.Drawing.Point(327, 231);
            this.Numerador.Name = "Numerador";
            this.Numerador.Size = new System.Drawing.Size(51, 22);
            this.Numerador.TabIndex = 18;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 219);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 45);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Location = new System.Drawing.Point(197, 85);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(54, 16);
            this.lblArreglo.TabIndex = 16;
            this.lblArreglo.Text = "Arreglo ";
            // 
            // FrmBqHASH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.Numerador2);
            this.Controls.Add(this.Numerador);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblArreglo);
            this.Name = "FrmBqHASH";
            this.Text = "FrmBusquedaHASH";
            ((System.ComponentModel.ISupportInitialize)(this.Numerador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numerador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown Numerador2;
        private System.Windows.Forms.NumericUpDown Numerador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblArreglo;
    }
}