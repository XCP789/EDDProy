namespace EDDemo.Recursividad
{
    partial class FrmRecursividad
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
            this.numericFactorial = new System.Windows.Forms.NumericUpDown();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.lblResultadoFactorial = new System.Windows.Forms.Label();
            this.numericBase = new System.Windows.Forms.NumericUpDown();
            this.numericExponente = new System.Windows.Forms.NumericUpDown();
            this.lblResultadoPotencia = new System.Windows.Forms.Label();
            this.btnCalcularPotencia = new System.Windows.Forms.Button();
            this.numericTamañoArreglo = new System.Windows.Forms.NumericUpDown();
            this.btnGenerarArreglo = new System.Windows.Forms.Button();
            this.lblArreglo = new System.Windows.Forms.Label();
            this.lblResultadoArreglo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExponente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamañoArreglo)).BeginInit();
            this.SuspendLayout();
            // 
            // numericFactorial
            // 
            this.numericFactorial.Location = new System.Drawing.Point(92, 80);
            this.numericFactorial.Name = "numericFactorial";
            this.numericFactorial.Size = new System.Drawing.Size(86, 22);
            this.numericFactorial.TabIndex = 0;
            // 
            // btnCalcularFactorial
            // 
            this.btnCalcularFactorial.Location = new System.Drawing.Point(199, 80);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularFactorial.TabIndex = 1;
            this.btnCalcularFactorial.Text = "calcular";
            this.btnCalcularFactorial.UseVisualStyleBackColor = true;
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);
            // 
            // lblResultadoFactorial
            // 
            this.lblResultadoFactorial.AutoSize = true;
            this.lblResultadoFactorial.Location = new System.Drawing.Point(89, 45);
            this.lblResultadoFactorial.Name = "lblResultadoFactorial";
            this.lblResultadoFactorial.Size = new System.Drawing.Size(69, 16);
            this.lblResultadoFactorial.TabIndex = 2;
            this.lblResultadoFactorial.Text = "Resultado";
            // 
            // numericBase
            // 
            this.numericBase.Location = new System.Drawing.Point(136, 297);
            this.numericBase.Name = "numericBase";
            this.numericBase.Size = new System.Drawing.Size(68, 22);
            this.numericBase.TabIndex = 3;
            // 
            // numericExponente
            // 
            this.numericExponente.Location = new System.Drawing.Point(136, 336);
            this.numericExponente.Name = "numericExponente";
            this.numericExponente.Size = new System.Drawing.Size(68, 22);
            this.numericExponente.TabIndex = 4;
            // 
            // lblResultadoPotencia
            // 
            this.lblResultadoPotencia.AutoSize = true;
            this.lblResultadoPotencia.Location = new System.Drawing.Point(89, 249);
            this.lblResultadoPotencia.Name = "lblResultadoPotencia";
            this.lblResultadoPotencia.Size = new System.Drawing.Size(69, 16);
            this.lblResultadoPotencia.TabIndex = 5;
            this.lblResultadoPotencia.Text = "Resultado";
            // 
            // btnCalcularPotencia
            // 
            this.btnCalcularPotencia.Location = new System.Drawing.Point(227, 308);
            this.btnCalcularPotencia.Name = "btnCalcularPotencia";
            this.btnCalcularPotencia.Size = new System.Drawing.Size(70, 50);
            this.btnCalcularPotencia.TabIndex = 6;
            this.btnCalcularPotencia.Text = "calcular";
            this.btnCalcularPotencia.UseVisualStyleBackColor = true;
            this.btnCalcularPotencia.Click += new System.EventHandler(this.btnCalcularPotencia_Click_1);
            // 
            // numericTamañoArreglo
            // 
            this.numericTamañoArreglo.Location = new System.Drawing.Point(475, 162);
            this.numericTamañoArreglo.Name = "numericTamañoArreglo";
            this.numericTamañoArreglo.Size = new System.Drawing.Size(86, 22);
            this.numericTamañoArreglo.TabIndex = 7;
            // 
            // btnGenerarArreglo
            // 
            this.btnGenerarArreglo.Location = new System.Drawing.Point(475, 206);
            this.btnGenerarArreglo.Name = "btnGenerarArreglo";
            this.btnGenerarArreglo.Size = new System.Drawing.Size(70, 50);
            this.btnGenerarArreglo.TabIndex = 8;
            this.btnGenerarArreglo.Text = "calcular";
            this.btnGenerarArreglo.UseVisualStyleBackColor = true;
            this.btnGenerarArreglo.Click += new System.EventHandler(this.btnGenerarArreglo_Click);
            // 
            // lblArreglo
            // 
            this.lblArreglo.AutoSize = true;
            this.lblArreglo.Location = new System.Drawing.Point(472, 87);
            this.lblArreglo.Name = "lblArreglo";
            this.lblArreglo.Size = new System.Drawing.Size(51, 16);
            this.lblArreglo.TabIndex = 9;
            this.lblArreglo.Text = "Arreglo";
            // 
            // lblResultadoArreglo
            // 
            this.lblResultadoArreglo.AutoSize = true;
            this.lblResultadoArreglo.Location = new System.Drawing.Point(472, 122);
            this.lblResultadoArreglo.Name = "lblResultadoArreglo";
            this.lblResultadoArreglo.Size = new System.Drawing.Size(69, 16);
            this.lblResultadoArreglo.TabIndex = 10;
            this.lblResultadoArreglo.Text = "Resultado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "FACTORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "POTENCIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "ARREGLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "BASE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "EXPONENTE";
            // 
            // FrmRecursividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultadoArreglo);
            this.Controls.Add(this.lblArreglo);
            this.Controls.Add(this.btnGenerarArreglo);
            this.Controls.Add(this.numericTamañoArreglo);
            this.Controls.Add(this.btnCalcularPotencia);
            this.Controls.Add(this.lblResultadoPotencia);
            this.Controls.Add(this.numericExponente);
            this.Controls.Add(this.numericBase);
            this.Controls.Add(this.lblResultadoFactorial);
            this.Controls.Add(this.btnCalcularFactorial);
            this.Controls.Add(this.numericFactorial);
            this.Name = "FrmRecursividad";
            this.Text = "FrmRecursividad";
            ((System.ComponentModel.ISupportInitialize)(this.numericFactorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExponente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTamañoArreglo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericFactorial;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Label lblResultadoFactorial;
        private System.Windows.Forms.NumericUpDown numericBase;
        private System.Windows.Forms.NumericUpDown numericExponente;
        private System.Windows.Forms.Label lblResultadoPotencia;
        private System.Windows.Forms.Button btnCalcularPotencia;
        private System.Windows.Forms.NumericUpDown numericTamañoArreglo;
        private System.Windows.Forms.Button btnGenerarArreglo;
        private System.Windows.Forms.Label lblArreglo;
        private System.Windows.Forms.Label lblResultadoArreglo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}