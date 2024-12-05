namespace EDDemo.Estructuras_Lineales
{
    partial class FormColas
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
            this.LstCola = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstCola
            // 
            this.LstCola.FormattingEnabled = true;
            this.LstCola.ItemHeight = 16;
            this.LstCola.Location = new System.Drawing.Point(146, 78);
            this.LstCola.Name = "LstCola";
            this.LstCola.Size = new System.Drawing.Size(120, 260);
            this.LstCola.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(304, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa los valores:";
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(307, 181);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(132, 37);
            this.btnQueue.TabIndex = 2;
            this.btnQueue.Text = "AGREGAR";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click_1);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(307, 241);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(132, 37);
            this.btnDequeue.TabIndex = 3;
            this.btnDequeue.Text = "ELIMINAR";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click_1);
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(307, 122);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(178, 22);
            this.txtCaja.TabIndex = 4;
            this.txtCaja.TextChanged += new System.EventHandler(this.txtCaja_TextChanged);
            // 
            // btnVaciar
            // 
            this.btnVaciar.Location = new System.Drawing.Point(307, 301);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(132, 37);
            this.btnVaciar.TabIndex = 5;
            this.btnVaciar.Text = "VACIAR";
            this.btnVaciar.UseVisualStyleBackColor = true;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(567, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 37);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "SALIR";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstCola);
            this.Name = "FormColas";
            this.Text = "FormColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.Button btnExit;
    }
}