namespace BancoAvVillians
{
    partial class FormCrearCuenta
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
            this.txbCCUsuario = new System.Windows.Forms.TextBox();
            this.txbCCCedula = new System.Windows.Forms.TextBox();
            this.btnCrearCuentaA = new System.Windows.Forms.Button();
            this.lbCCUsuario = new System.Windows.Forms.Label();
            this.lbCCCedula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbCCUsuario
            // 
            this.txbCCUsuario.Location = new System.Drawing.Point(260, 34);
            this.txbCCUsuario.Name = "txbCCUsuario";
            this.txbCCUsuario.Size = new System.Drawing.Size(343, 20);
            this.txbCCUsuario.TabIndex = 0;
            // 
            // txbCCCedula
            // 
            this.txbCCCedula.Location = new System.Drawing.Point(260, 82);
            this.txbCCCedula.Name = "txbCCCedula";
            this.txbCCCedula.Size = new System.Drawing.Size(343, 20);
            this.txbCCCedula.TabIndex = 1;
            // 
            // btnCrearCuentaA
            // 
            this.btnCrearCuentaA.Location = new System.Drawing.Point(354, 135);
            this.btnCrearCuentaA.Name = "btnCrearCuentaA";
            this.btnCrearCuentaA.Size = new System.Drawing.Size(143, 60);
            this.btnCrearCuentaA.TabIndex = 2;
            this.btnCrearCuentaA.Text = "Aceptar";
            this.btnCrearCuentaA.UseVisualStyleBackColor = true;
            this.btnCrearCuentaA.Click += new System.EventHandler(this.btnCC_Click);
            // 
            // lbCCUsuario
            // 
            this.lbCCUsuario.AutoSize = true;
            this.lbCCUsuario.Location = new System.Drawing.Point(60, 37);
            this.lbCCUsuario.Name = "lbCCUsuario";
            this.lbCCUsuario.Size = new System.Drawing.Size(194, 13);
            this.lbCCUsuario.TabIndex = 3;
            this.lbCCUsuario.Text = "Ingrese el nombre completo del usuario:";
            // 
            // lbCCCedula
            // 
            this.lbCCCedula.AutoSize = true;
            this.lbCCCedula.Location = new System.Drawing.Point(2, 85);
            this.lbCCCedula.Name = "lbCCCedula";
            this.lbCCCedula.Size = new System.Drawing.Size(252, 13);
            this.lbCCCedula.TabIndex = 4;
            this.lbCCCedula.Text = "Ingrese la cédula del usuario sin puntos ni espacios:";
            // 
            // FormCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCCCedula);
            this.Controls.Add(this.lbCCUsuario);
            this.Controls.Add(this.btnCrearCuentaA);
            this.Controls.Add(this.txbCCCedula);
            this.Controls.Add(this.txbCCUsuario);
            this.Name = "FormCrearCuenta";
            this.Text = "FormCrearCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCCUsuario;
        private System.Windows.Forms.TextBox txbCCCedula;
        private System.Windows.Forms.Button btnCrearCuentaA;
        private System.Windows.Forms.Label lbCCUsuario;
        private System.Windows.Forms.Label lbCCCedula;
    }
}