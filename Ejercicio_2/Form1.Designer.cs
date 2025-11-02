namespace Ejercicio_2
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
            btnRegistrarReclamo = new Button();
            tbMotivo = new TextBox();
            tbNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            btnCrearOrdenTrab = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lbxVerOrdenTrabajo = new ListBox();
            btnEjecutarOrden = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarReclamo);
            groupBox1.Controls.Add(tbMotivo);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recepcion de reclamos";
            // 
            // btnRegistrarReclamo
            // 
            btnRegistrarReclamo.Location = new Point(137, 244);
            btnRegistrarReclamo.Name = "btnRegistrarReclamo";
            btnRegistrarReclamo.Size = new Size(90, 47);
            btnRegistrarReclamo.TabIndex = 5;
            btnRegistrarReclamo.Text = "Registrar Reclamo";
            btnRegistrarReclamo.UseVisualStyleBackColor = true;
            btnRegistrarReclamo.Click += btnRegistrarReclamo_Click;
            // 
            // tbMotivo
            // 
            tbMotivo.Location = new Point(93, 117);
            tbMotivo.Multiline = true;
            tbMotivo.Name = "tbMotivo";
            tbMotivo.Size = new Size(169, 105);
            tbMotivo.TabIndex = 4;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(93, 65);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(169, 23);
            tbNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 117);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Motivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos de Reclamo";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(btnCrearOrdenTrab);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(352, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(271, 315);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Planificar Trabajo";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 55);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 169);
            listBox1.TabIndex = 6;
            // 
            // btnCrearOrdenTrab
            // 
            btnCrearOrdenTrab.Location = new Point(81, 244);
            btnCrearOrdenTrab.Name = "btnCrearOrdenTrab";
            btnCrearOrdenTrab.Size = new Size(90, 47);
            btnCrearOrdenTrab.TabIndex = 5;
            btnCrearOrdenTrab.Text = "Crear Orden de Trabajo";
            btnCrearOrdenTrab.UseVisualStyleBackColor = true;
            btnCrearOrdenTrab.Click += btnCrearOrdenTrab_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 117);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 65);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 27);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 0;
            label6.Text = "Lista de Reclamos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lbxVerOrdenTrabajo);
            groupBox3.Controls.Add(btnEjecutarOrden);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(629, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(271, 315);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ordenes de trabajo";
            // 
            // lbxVerOrdenTrabajo
            // 
            lbxVerOrdenTrabajo.FormattingEnabled = true;
            lbxVerOrdenTrabajo.ItemHeight = 15;
            lbxVerOrdenTrabajo.Location = new Point(16, 55);
            lbxVerOrdenTrabajo.Name = "lbxVerOrdenTrabajo";
            lbxVerOrdenTrabajo.Size = new Size(237, 169);
            lbxVerOrdenTrabajo.TabIndex = 6;
            // 
            // btnEjecutarOrden
            // 
            btnEjecutarOrden.Location = new Point(81, 235);
            btnEjecutarOrden.Name = "btnEjecutarOrden";
            btnEjecutarOrden.Size = new Size(90, 65);
            btnEjecutarOrden.TabIndex = 5;
            btnEjecutarOrden.Text = "Ejecutar Orden De trabajo";
            btnEjecutarOrden.UseVisualStyleBackColor = true;
            btnEjecutarOrden.Click += btnEjecutarOrden_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 117);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 65);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 27);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 0;
            label9.Text = "Trabajos ejecutados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 346);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnRegistrarReclamo;
        private TextBox tbMotivo;
        private TextBox tbNombre;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnCrearOrdenTrab;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private ListBox lbxVerOrdenTrabajo;
        private Button btnEjecutarOrden;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
