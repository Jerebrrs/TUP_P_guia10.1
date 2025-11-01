namespace Guia_10._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnCorrespondencia = new Button();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            tbDni = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            lbVerSectorCompras = new ListBox();
            groupBox3 = new GroupBox();
            btnEntregarPaquete = new Button();
            btnIniciarReparto = new Button();
            groupBox4 = new GroupBox();
            lbDireccion = new Label();
            lbNombre = new Label();
            lbDni = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lbListadoAEntregar = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCorrespondencia);
            groupBox1.Controls.Add(tbDireccion);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbDni);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Atencion al Cliente";
            // 
            // btnCorrespondencia
            // 
            btnCorrespondencia.Location = new Point(48, 212);
            btnCorrespondencia.Name = "btnCorrespondencia";
            btnCorrespondencia.Size = new Size(110, 51);
            btnCorrespondencia.TabIndex = 6;
            btnCorrespondencia.Text = "Recibir Correspondencia";
            btnCorrespondencia.UseVisualStyleBackColor = true;
            btnCorrespondencia.Click += btnCorrespondencia_Click;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(97, 155);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(100, 23);
            tbDireccion.TabIndex = 5;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(97, 108);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 4;
            // 
            // tbDni
            // 
            tbDni.Location = new Point(97, 59);
            tbDni.Name = "tbDni";
            tbDni.Size = new Size(100, 23);
            tbDni.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 163);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 108);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 62);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(lbVerSectorCompras);
            groupBox2.Location = new Point(234, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 280);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paquetes en el sector enbarque";
            // 
            // button1
            // 
            button1.Location = new Point(62, 237);
            button1.Name = "button1";
            button1.Size = new Size(110, 26);
            button1.TabIndex = 7;
            button1.Text = "Preparar Camion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbVerSectorCompras
            // 
            lbVerSectorCompras.FormattingEnabled = true;
            lbVerSectorCompras.ItemHeight = 15;
            lbVerSectorCompras.Location = new Point(16, 27);
            lbVerSectorCompras.Name = "lbVerSectorCompras";
            lbVerSectorCompras.Size = new Size(216, 199);
            lbVerSectorCompras.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEntregarPaquete);
            groupBox3.Controls.Add(btnIniciarReparto);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(490, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(256, 280);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Tarea de Reparto";
            // 
            // btnEntregarPaquete
            // 
            btnEntregarPaquete.Location = new Point(128, 129);
            btnEntregarPaquete.Name = "btnEntregarPaquete";
            btnEntregarPaquete.Size = new Size(94, 49);
            btnEntregarPaquete.TabIndex = 9;
            btnEntregarPaquete.Text = "Entregar Paquete";
            btnEntregarPaquete.UseVisualStyleBackColor = true;
            btnEntregarPaquete.Click += btnEntregarPaquete_Click;
            // 
            // btnIniciarReparto
            // 
            btnIniciarReparto.Location = new Point(28, 129);
            btnIniciarReparto.Name = "btnIniciarReparto";
            btnIniciarReparto.Size = new Size(94, 49);
            btnIniciarReparto.TabIndex = 8;
            btnIniciarReparto.Text = "Iniciar Reparto";
            btnIniciarReparto.UseVisualStyleBackColor = true;
            btnIniciarReparto.Click += btnIniciarReparto_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbDireccion);
            groupBox4.Controls.Add(lbNombre);
            groupBox4.Controls.Add(lbDni);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(15, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(225, 101);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Proximo a entregar";
            // 
            // lbDireccion
            // 
            lbDireccion.BackColor = SystemColors.ActiveBorder;
            lbDireccion.Location = new Point(102, 68);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(117, 15);
            lbDireccion.TabIndex = 5;
            // 
            // lbNombre
            // 
            lbNombre.BackColor = SystemColors.ActiveBorder;
            lbNombre.Location = new Point(102, 45);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(117, 15);
            lbNombre.TabIndex = 4;
            // 
            // lbDni
            // 
            lbDni.BackColor = SystemColors.ActiveBorder;
            lbDni.Location = new Point(102, 19);
            lbDni.Name = "lbDni";
            lbDni.Size = new Size(117, 15);
            lbDni.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 68);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 2;
            label6.Text = "Direccion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 45);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 19);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "DNI:";
            // 
            // lbListadoAEntregar
            // 
            lbListadoAEntregar.FormattingEnabled = true;
            lbListadoAEntregar.ItemHeight = 15;
            lbListadoAEntregar.Location = new Point(515, 214);
            lbListadoAEntregar.Name = "lbListadoAEntregar";
            lbListadoAEntregar.Size = new Size(216, 64);
            lbListadoAEntregar.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 299);
            Controls.Add(lbListadoAEntregar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCorrespondencia;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private TextBox tbDni;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button1;
        private ListBox lbVerSectorCompras;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label4;
        private Button btnEntregarPaquete;
        private Button btnIniciarReparto;
        private Label lbDireccion;
        private Label lbNombre;
        private Label lbDni;
        private Label label6;
        private Label label5;
        private ListBox lbListadoAEntregar;
    }
}
