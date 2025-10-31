namespace Guia_10._1
{
    partial class CapCamion
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
            lbCap = new Label();
            dupCapacidad = new DomainUpDown();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lbCap
            // 
            lbCap.AutoSize = true;
            lbCap.Location = new Point(27, 38);
            lbCap.Name = "lbCap";
            lbCap.Size = new Size(127, 15);
            lbCap.TabIndex = 0;
            lbCap.Text = "Capacidad de Camion:";
            // 
            // dupCapacidad
            // 
            dupCapacidad.Location = new Point(187, 36);
            dupCapacidad.Name = "dupCapacidad";
            dupCapacidad.Size = new Size(120, 23);
            dupCapacidad.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(127, 79);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 33);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // CapCamion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 134);
            Controls.Add(btnAceptar);
            Controls.Add(dupCapacidad);
            Controls.Add(lbCap);
            Name = "CapCamion";
            Text = "CapCamion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCap;
        public Button btnAceptar;
        public DomainUpDown dupCapacidad;
    }
}