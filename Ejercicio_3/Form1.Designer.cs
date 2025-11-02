namespace Ejercicio_3
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
            btnAtender = new Button();
            label3 = new Label();
            lbPedidosEntra = new ListBox();
            tbDirreccion = new TextBox();
            tbTel = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnAsignarCliente = new Button();
            lbOcupados = new ListBox();
            label5 = new Label();
            label4 = new Label();
            lbVehiculosDisponibles = new ListBox();
            btnLiberar = new GroupBox();
            btnLive = new Button();
            dupNumero = new DomainUpDown();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            btnLiberar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAtender);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbPedidosEntra);
            groupBox1.Controls.Add(tbDirreccion);
            groupBox1.Controls.Add(tbTel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recibir Pedido Taxi";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(76, 333);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(88, 42);
            btnAtender.TabIndex = 6;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 215);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Pedidos Entrantes:";
            // 
            // lbPedidosEntra
            // 
            lbPedidosEntra.FormattingEnabled = true;
            lbPedidosEntra.ItemHeight = 15;
            lbPedidosEntra.Location = new Point(13, 233);
            lbPedidosEntra.Name = "lbPedidosEntra";
            lbPedidosEntra.Size = new Size(221, 94);
            lbPedidosEntra.TabIndex = 4;
            // 
            // tbDirreccion
            // 
            tbDirreccion.Location = new Point(94, 81);
            tbDirreccion.Multiline = true;
            tbDirreccion.Name = "tbDirreccion";
            tbDirreccion.Size = new Size(140, 108);
            tbDirreccion.TabIndex = 3;
            // 
            // tbTel
            // 
            tbTel.Location = new Point(94, 42);
            tbTel.Name = "tbTel";
            tbTel.Size = new Size(140, 23);
            tbTel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Telefono:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAsignarCliente);
            groupBox2.Controls.Add(lbOcupados);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbVehiculosDisponibles);
            groupBox2.Location = new Point(258, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 391);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Central De Taxis";
            // 
            // btnAsignarCliente
            // 
            btnAsignarCliente.Location = new Point(60, 333);
            btnAsignarCliente.Name = "btnAsignarCliente";
            btnAsignarCliente.Size = new Size(114, 42);
            btnAsignarCliente.TabIndex = 7;
            btnAsignarCliente.Text = "Asignar Coche a Cliente:";
            btnAsignarCliente.UseVisualStyleBackColor = true;
            btnAsignarCliente.Click += btnAsignarCliente_Click;
            // 
            // lbOcupados
            // 
            lbOcupados.FormattingEnabled = true;
            lbOcupados.ItemHeight = 15;
            lbOcupados.Location = new Point(6, 233);
            lbOcupados.Name = "lbOcupados";
            lbOcupados.Size = new Size(221, 94);
            lbOcupados.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 205);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 8;
            label5.Text = "Vehiculos Ocupados:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 42);
            label4.Name = "label4";
            label4.Size = new Size(124, 15);
            label4.TabIndex = 7;
            label4.Text = "Vehiculos Disponibles:";
            // 
            // lbVehiculosDisponibles
            // 
            lbVehiculosDisponibles.FormattingEnabled = true;
            lbVehiculosDisponibles.ItemHeight = 15;
            lbVehiculosDisponibles.Location = new Point(6, 60);
            lbVehiculosDisponibles.Name = "lbVehiculosDisponibles";
            lbVehiculosDisponibles.Size = new Size(221, 94);
            lbVehiculosDisponibles.TabIndex = 5;
            // 
            // btnLiberar
            // 
            btnLiberar.Controls.Add(btnLive);
            btnLiberar.Controls.Add(dupNumero);
            btnLiberar.Controls.Add(label6);
            btnLiberar.Location = new Point(534, 22);
            btnLiberar.Name = "btnLiberar";
            btnLiberar.Size = new Size(240, 381);
            btnLiberar.TabIndex = 1;
            btnLiberar.TabStop = false;
            btnLiberar.Text = "Liberar Coche:";
            // 
            // btnLive
            // 
            btnLive.Location = new Point(68, 323);
            btnLive.Name = "btnLive";
            btnLive.Size = new Size(114, 42);
            btnLive.TabIndex = 10;
            btnLive.Text = "Liberar Coche";
            btnLive.UseVisualStyleBackColor = true;
            btnLive.Click += btnLive_Click;
            // 
            // dupNumero
            // 
            dupNumero.Location = new Point(135, 179);
            dupNumero.Name = "dupNumero";
            dupNumero.Size = new Size(99, 23);
            dupNumero.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 181);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 10;
            label6.Text = "Numero De Vehiculo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLiberar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            btnLiberar.ResumeLayout(false);
            btnLiberar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAtender;
        private Label label3;
        private ListBox lbPedidosEntra;
        private TextBox tbDirreccion;
        private TextBox tbTel;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox btnLiberar;
        private Button btnAsignarCliente;
        private ListBox lbOcupados;
        private Label label5;
        private Label label4;
        private ListBox lbVehiculosDisponibles;
        private Button btnLive;
        private DomainUpDown dupNumero;
        private Label label6;
    }
}
