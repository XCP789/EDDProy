
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRePreOrden = new System.Windows.Forms.Label();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblReInOrden = new System.Windows.Forms.Label();
            this.lblRePostOrden = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnDibujarA = new System.Windows.Forms.Button();
            this.btnPodarArbol = new System.Windows.Forms.Button();
            this.btnEliminarSucesor = new System.Windows.Forms.Button();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnReAmplitud = new System.Windows.Forms.Button();
            this.lblReAmplitud = new System.Windows.Forms.Label();
            this.btnAltura = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblContarHojas = new System.Windows.Forms.Label();
            this.btnContarHojas = new System.Windows.Forms.Button();
            this.lblContarNodos = new System.Windows.Forms.Label();
            this.btnContarNodo = new System.Windows.Forms.Button();
            this.lblAblCompleto = new System.Windows.Forms.Label();
            this.btnAblCompleto = new System.Windows.Forms.Button();
            this.lblArbolLleno = new System.Windows.Forms.Label();
            this.btnArbolLleno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDato.Location = new System.Drawing.Point(371, 303);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(139, 34);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(514, 303);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(311, 17);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(569, 275);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(29, 193);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 43);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(29, 134);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(124, 43);
            this.btnRecorrer.TabIndex = 3;
            this.btnRecorrer.Text = "recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(29, 73);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(124, 43);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(29, 13);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(124, 43);
            this.btnCrearArbol.TabIndex = 10;
            this.btnCrearArbol.Text = "crear arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(316, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "PreOrden";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "InOrden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "PostOrden";
            // 
            // lblRePreOrden
            // 
            this.lblRePreOrden.AutoSize = true;
            this.lblRePreOrden.Location = new System.Drawing.Point(108, 341);
            this.lblRePreOrden.Name = "lblRePreOrden";
            this.lblRePreOrden.Size = new System.Drawing.Size(126, 16);
            this.lblRePreOrden.TabIndex = 18;
            this.lblRePreOrden.Text = "Recorrido Preorden";
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNodos.Location = new System.Drawing.Point(166, 17);
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(68, 30);
            this.txtNodos.TabIndex = 19;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblReInOrden
            // 
            this.lblReInOrden.AutoSize = true;
            this.lblReInOrden.Location = new System.Drawing.Point(108, 368);
            this.lblReInOrden.Name = "lblReInOrden";
            this.lblReInOrden.Size = new System.Drawing.Size(115, 16);
            this.lblReInOrden.TabIndex = 20;
            this.lblReInOrden.Text = "Recorrido Inorden";
            // 
            // lblRePostOrden
            // 
            this.lblRePostOrden.AutoSize = true;
            this.lblRePostOrden.Location = new System.Drawing.Point(108, 393);
            this.lblRePostOrden.Name = "lblRePostOrden";
            this.lblRePostOrden.Size = new System.Drawing.Size(132, 16);
            this.lblRePostOrden.TabIndex = 21;
            this.lblRePostOrden.Text = "Recorrido Postorden";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(166, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(62, 30);
            this.txtBuscar.TabIndex = 22;
            // 
            // btnDibujarA
            // 
            this.btnDibujarA.Location = new System.Drawing.Point(29, 256);
            this.btnDibujarA.Margin = new System.Windows.Forms.Padding(2);
            this.btnDibujarA.Name = "btnDibujarA";
            this.btnDibujarA.Size = new System.Drawing.Size(124, 43);
            this.btnDibujarA.TabIndex = 23;
            this.btnDibujarA.Text = "dibujar";
            this.btnDibujarA.UseVisualStyleBackColor = true;
            this.btnDibujarA.Click += new System.EventHandler(this.btnDibujarA_Click);
            // 
            // btnPodarArbol
            // 
            this.btnPodarArbol.Location = new System.Drawing.Point(166, 134);
            this.btnPodarArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodarArbol.Name = "btnPodarArbol";
            this.btnPodarArbol.Size = new System.Drawing.Size(124, 43);
            this.btnPodarArbol.TabIndex = 24;
            this.btnPodarArbol.Text = "podar";
            this.btnPodarArbol.UseVisualStyleBackColor = true;
            this.btnPodarArbol.Click += new System.EventHandler(this.btnPodarArbol_Click);
            // 
            // btnEliminarSucesor
            // 
            this.btnEliminarSucesor.Location = new System.Drawing.Point(166, 256);
            this.btnEliminarSucesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarSucesor.Name = "btnEliminarSucesor";
            this.btnEliminarSucesor.Size = new System.Drawing.Size(124, 43);
            this.btnEliminarSucesor.TabIndex = 25;
            this.btnEliminarSucesor.Text = "Eli sucesor";
            this.btnEliminarSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarSucesor.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(166, 193);
            this.btnEliminarPredecesor.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(124, 43);
            this.btnEliminarPredecesor.TabIndex = 26;
            this.btnEliminarPredecesor.Text = "Eli predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnReAmplitud
            // 
            this.btnReAmplitud.Location = new System.Drawing.Point(578, 446);
            this.btnReAmplitud.Margin = new System.Windows.Forms.Padding(2);
            this.btnReAmplitud.Name = "btnReAmplitud";
            this.btnReAmplitud.Size = new System.Drawing.Size(124, 43);
            this.btnReAmplitud.TabIndex = 27;
            this.btnReAmplitud.Text = "Amplitud";
            this.btnReAmplitud.UseVisualStyleBackColor = true;
            this.btnReAmplitud.Click += new System.EventHandler(this.btnReAmplitud_Click);
            // 
            // lblReAmplitud
            // 
            this.lblReAmplitud.AutoSize = true;
            this.lblReAmplitud.Location = new System.Drawing.Point(707, 459);
            this.lblReAmplitud.Name = "lblReAmplitud";
            this.lblReAmplitud.Size = new System.Drawing.Size(75, 16);
            this.lblReAmplitud.TabIndex = 28;
            this.lblReAmplitud.Text = "AMPLITUD";
            this.lblReAmplitud.Click += new System.EventHandler(this.lblReAmplitud_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(311, 446);
            this.btnAltura.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(124, 43);
            this.btnAltura.TabIndex = 29;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(440, 459);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(61, 16);
            this.lblAltura.TabIndex = 30;
            this.lblAltura.Text = "ALTURA";
            // 
            // lblContarHojas
            // 
            this.lblContarHojas.AutoSize = true;
            this.lblContarHojas.Location = new System.Drawing.Point(440, 354);
            this.lblContarHojas.Name = "lblContarHojas";
            this.lblContarHojas.Size = new System.Drawing.Size(82, 16);
            this.lblContarHojas.TabIndex = 32;
            this.lblContarHojas.Text = "Contar hojas";
            // 
            // btnContarHojas
            // 
            this.btnContarHojas.Location = new System.Drawing.Point(311, 341);
            this.btnContarHojas.Margin = new System.Windows.Forms.Padding(2);
            this.btnContarHojas.Name = "btnContarHojas";
            this.btnContarHojas.Size = new System.Drawing.Size(124, 43);
            this.btnContarHojas.TabIndex = 31;
            this.btnContarHojas.Text = "contar H";
            this.btnContarHojas.UseVisualStyleBackColor = true;
            this.btnContarHojas.Click += new System.EventHandler(this.btnContarHojas_Click);
            // 
            // lblContarNodos
            // 
            this.lblContarNodos.AutoSize = true;
            this.lblContarNodos.Location = new System.Drawing.Point(440, 404);
            this.lblContarNodos.Name = "lblContarNodos";
            this.lblContarNodos.Size = new System.Drawing.Size(87, 16);
            this.lblContarNodos.TabIndex = 34;
            this.lblContarNodos.Text = "Contar nodos";
            // 
            // btnContarNodo
            // 
            this.btnContarNodo.Location = new System.Drawing.Point(311, 391);
            this.btnContarNodo.Margin = new System.Windows.Forms.Padding(2);
            this.btnContarNodo.Name = "btnContarNodo";
            this.btnContarNodo.Size = new System.Drawing.Size(124, 43);
            this.btnContarNodo.TabIndex = 33;
            this.btnContarNodo.Text = "contar N";
            this.btnContarNodo.UseVisualStyleBackColor = true;
            this.btnContarNodo.Click += new System.EventHandler(this.btnContarNodo_Click);
            // 
            // lblAblCompleto
            // 
            this.lblAblCompleto.AutoSize = true;
            this.lblAblCompleto.Location = new System.Drawing.Point(707, 404);
            this.lblAblCompleto.Name = "lblAblCompleto";
            this.lblAblCompleto.Size = new System.Drawing.Size(63, 16);
            this.lblAblCompleto.TabIndex = 36;
            this.lblAblCompleto.Text = "completo";
            // 
            // btnAblCompleto
            // 
            this.btnAblCompleto.Location = new System.Drawing.Point(578, 391);
            this.btnAblCompleto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAblCompleto.Name = "btnAblCompleto";
            this.btnAblCompleto.Size = new System.Drawing.Size(124, 43);
            this.btnAblCompleto.TabIndex = 35;
            this.btnAblCompleto.Text = "abl completo";
            this.btnAblCompleto.UseVisualStyleBackColor = true;
            this.btnAblCompleto.Click += new System.EventHandler(this.btnAblCompleto_Click);
            // 
            // lblArbolLleno
            // 
            this.lblArbolLleno.AutoSize = true;
            this.lblArbolLleno.Location = new System.Drawing.Point(707, 352);
            this.lblArbolLleno.Name = "lblArbolLleno";
            this.lblArbolLleno.Size = new System.Drawing.Size(70, 16);
            this.lblArbolLleno.TabIndex = 38;
            this.lblArbolLleno.Text = "arbol lleno";
            // 
            // btnArbolLleno
            // 
            this.btnArbolLleno.Location = new System.Drawing.Point(578, 339);
            this.btnArbolLleno.Margin = new System.Windows.Forms.Padding(2);
            this.btnArbolLleno.Name = "btnArbolLleno";
            this.btnArbolLleno.Size = new System.Drawing.Size(124, 43);
            this.btnArbolLleno.TabIndex = 37;
            this.btnArbolLleno.Text = "abl lleno";
            this.btnArbolLleno.UseVisualStyleBackColor = true;
            this.btnArbolLleno.Click += new System.EventHandler(this.btnArbolLleno_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.lblArbolLleno);
            this.Controls.Add(this.btnArbolLleno);
            this.Controls.Add(this.lblAblCompleto);
            this.Controls.Add(this.btnAblCompleto);
            this.Controls.Add(this.lblContarNodos);
            this.Controls.Add(this.btnContarNodo);
            this.Controls.Add(this.lblContarHojas);
            this.Controls.Add(this.btnContarHojas);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.lblReAmplitud);
            this.Controls.Add(this.btnReAmplitud);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.btnEliminarSucesor);
            this.Controls.Add(this.btnPodarArbol);
            this.Controls.Add(this.btnDibujarA);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblRePostOrden);
            this.Controls.Add(this.lblReInOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.lblRePreOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRePreOrden;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblReInOrden;
        private System.Windows.Forms.Label lblRePostOrden;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnDibujarA;
        private System.Windows.Forms.Button btnPodarArbol;
        private System.Windows.Forms.Button btnEliminarSucesor;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnReAmplitud;
        private System.Windows.Forms.Label lblReAmplitud;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblContarHojas;
        private System.Windows.Forms.Button btnContarHojas;
        private System.Windows.Forms.Label lblContarNodos;
        private System.Windows.Forms.Button btnContarNodo;
        private System.Windows.Forms.Label lblAblCompleto;
        private System.Windows.Forms.Button btnAblCompleto;
        private System.Windows.Forms.Label lblArbolLleno;
        private System.Windows.Forms.Button btnArbolLleno;
    }
}