namespace BancoAvVillians
{
    partial class FormModificaciones
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
            this.txbNombreCompletoM = new System.Windows.Forms.TextBox();
            this.txbCedulaM = new System.Windows.Forms.TextBox();
            this.lbNombreCompletoM = new System.Windows.Forms.Label();
            this.lbCedulaC = new System.Windows.Forms.Label();
            this.btnAceptarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombreCompletoM
            // 
            this.txbNombreCompletoM.Location = new System.Drawing.Point(282, 35);
            this.txbNombreCompletoM.Name = "txbNombreCompletoM";
            this.txbNombreCompletoM.Size = new System.Drawing.Size(312, 20);
            this.txbNombreCompletoM.TabIndex = 0;
            // 
            // txbCedulaM
            // 
            this.txbCedulaM.Location = new System.Drawing.Point(282, 82);
            this.txbCedulaM.Name = "txbCedulaM";
            this.txbCedulaM.Size = new System.Drawing.Size(312, 20);
            this.txbCedulaM.TabIndex = 1;
            // 
            // lbNombreCompletoM
            // 
            this.lbNombreCompletoM.AutoSize = true;
            this.lbNombreCompletoM.Location = new System.Drawing.Point(82, 38);
            this.lbNombreCompletoM.Name = "lbNombreCompletoM";
            this.lbNombreCompletoM.Size = new System.Drawing.Size(194, 13);
            this.lbNombreCompletoM.TabIndex = 2;
            this.lbNombreCompletoM.Text = "Ingrese el nombre completo del usuario:";
            // 
            // lbCedulaC
            // 
            this.lbCedulaC.AutoSize = true;
            this.lbCedulaC.Location = new System.Drawing.Point(24, 85);
            this.lbCedulaC.Name = "lbCedulaC";
            this.lbCedulaC.Size = new System.Drawing.Size(252, 13);
            this.lbCedulaC.TabIndex = 3;
            this.lbCedulaC.Text = "Ingrese la cedula del usuario sin puntos ni espacios:";
            // 
            // btnAceptarM
            // 
            this.btnAceptarM.Location = new System.Drawing.Point(379, 129);
            this.btnAceptarM.Name = "btnAceptarM";
            this.btnAceptarM.Size = new System.Drawing.Size(115, 47);
            this.btnAceptarM.TabIndex = 4;
            this.btnAceptarM.Text = "Aceptar";
            this.btnAceptarM.UseVisualStyleBackColor = true;
            this.btnAceptarM.Click += new System.EventHandler(this.btnAceptarM_Click);
            // 
            // FormModificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptarM);
            this.Controls.Add(this.lbCedulaC);
            this.Controls.Add(this.lbNombreCompletoM);
            this.Controls.Add(this.txbCedulaM);
            this.Controls.Add(this.txbNombreCompletoM);
            this.Name = "FormModificaciones";
            this.Text = "FormModificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNombreCompletoM;
        private System.Windows.Forms.TextBox txbCedulaM;
        private System.Windows.Forms.Label lbNombreCompletoM;
        private System.Windows.Forms.Label lbCedulaC;
        private System.Windows.Forms.Button btnAceptarM;
    }
}