namespace prims_kruskal
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDibujarNodo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKruskal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Hasta = new System.Windows.Forms.ComboBox();
            this.Desde = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnDibujarEnlace = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafo6 = new System.Windows.Forms.Button();
            this.btnGrafo12 = new System.Windows.Forms.Button();
            this.btnGrafo3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDibujarNodo
            // 
            this.btnDibujarNodo.Location = new System.Drawing.Point(685, 169);
            this.btnDibujarNodo.Name = "btnDibujarNodo";
            this.btnDibujarNodo.Size = new System.Drawing.Size(141, 23);
            this.btnDibujarNodo.TabIndex = 0;
            this.btnDibujarNodo.Text = "Dibujar";
            this.btnDibujarNodo.UseVisualStyleBackColor = true;
            this.btnDibujarNodo.Click += new System.EventHandler(this.btnDibujarNodo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(153, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(34, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(34, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // btnKruskal
            // 
            this.btnKruskal.Location = new System.Drawing.Point(735, 500);
            this.btnKruskal.Name = "btnKruskal";
            this.btnKruskal.Size = new System.Drawing.Size(62, 23);
            this.btnKruskal.TabIndex = 1;
            this.btnKruskal.Text = "Calcular costo";
            this.btnKruskal.UseVisualStyleBackColor = true;
            this.btnKruskal.Click += new System.EventHandler(this.btnKruskal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(626, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 64);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar Nodo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Hasta);
            this.groupBox3.Controls.Add(this.Desde);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Location = new System.Drawing.Point(626, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 64);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insertar Enlace";
            // 
            // Hasta
            // 
            this.Hasta.FormattingEnabled = true;
            this.Hasta.Location = new System.Drawing.Point(180, 37);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(52, 21);
            this.Hasta.TabIndex = 11;
            // 
            // Desde
            // 
            this.Desde.FormattingEnabled = true;
            this.Desde.Location = new System.Drawing.Point(120, 37);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(52, 21);
            this.Desde.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Peso";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(34, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 3;
            // 
            // btnDibujarEnlace
            // 
            this.btnDibujarEnlace.Location = new System.Drawing.Point(686, 268);
            this.btnDibujarEnlace.Name = "btnDibujarEnlace";
            this.btnDibujarEnlace.Size = new System.Drawing.Size(141, 23);
            this.btnDibujarEnlace.TabIndex = 13;
            this.btnDibujarEnlace.Text = "Dibujar";
            this.btnDibujarEnlace.UseVisualStyleBackColor = true;
            this.btnDibujarEnlace.Click += new System.EventHandler(this.btnDibujarEnlace_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(7, 25);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.lblResultado);
            this.groupBox4.Location = new System.Drawing.Point(626, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 197);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // btnGrafo6
            // 
            this.btnGrafo6.Location = new System.Drawing.Point(722, 55);
            this.btnGrafo6.Name = "btnGrafo6";
            this.btnGrafo6.Size = new System.Drawing.Size(75, 23);
            this.btnGrafo6.TabIndex = 17;
            this.btnGrafo6.Text = "Grafo (6)";
            this.btnGrafo6.UseVisualStyleBackColor = true;
            this.btnGrafo6.Click += new System.EventHandler(this.btnGrafo6_Click);
            // 
            // btnGrafo12
            // 
            this.btnGrafo12.Location = new System.Drawing.Point(818, 55);
            this.btnGrafo12.Name = "btnGrafo12";
            this.btnGrafo12.Size = new System.Drawing.Size(75, 23);
            this.btnGrafo12.TabIndex = 18;
            this.btnGrafo12.Text = "Grafo (12)";
            this.btnGrafo12.UseVisualStyleBackColor = true;
            this.btnGrafo12.Click += new System.EventHandler(this.btnGrafo12_Click);
            // 
            // btnGrafo3
            // 
            this.btnGrafo3.Location = new System.Drawing.Point(626, 55);
            this.btnGrafo3.Name = "btnGrafo3";
            this.btnGrafo3.Size = new System.Drawing.Size(75, 23);
            this.btnGrafo3.TabIndex = 19;
            this.btnGrafo3.Text = "Grafo (3)";
            this.btnGrafo3.UseVisualStyleBackColor = true;
            this.btnGrafo3.Click += new System.EventHandler(this.btnGrafo3_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 535);
            this.Controls.Add(this.btnKruskal);
            this.Controls.Add(this.btnGrafo3);
            this.Controls.Add(this.btnGrafo12);
            this.Controls.Add(this.btnGrafo6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnDibujarEnlace);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDibujarNodo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Principal";
            this.Text = "Implementacion Prim & Kruskal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDibujarNodo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox Hasta;
        private System.Windows.Forms.ComboBox Desde;
        private System.Windows.Forms.Button btnDibujarEnlace;
        private System.Windows.Forms.Button btnKruskal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrafo6;
        private System.Windows.Forms.Button btnGrafo12;
        private System.Windows.Forms.Button btnGrafo3;
    }
}

