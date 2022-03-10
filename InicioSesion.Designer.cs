namespace BancoAvVillians
{
    partial class InicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnISA = new System.Windows.Forms.Button();
            this.btnISC = new System.Windows.Forms.Button();
            this.lbISA = new System.Windows.Forms.Label();
            this.lbISC = new System.Windows.Forms.Label();
            this.txbISAU = new System.Windows.Forms.TextBox();
            this.txbISAC = new System.Windows.Forms.TextBox();
            this.txbISCU = new System.Windows.Forms.TextBox();
            this.txbISCC = new System.Windows.Forms.TextBox();
            this.lbIS = new System.Windows.Forms.Label();
            this.lbISAU = new System.Windows.Forms.Label();
            this.lbISAC = new System.Windows.Forms.Label();
            this.lbISCU = new System.Windows.Forms.Label();
            this.lbISCC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnISA
            // 
            this.btnISA.Location = new System.Drawing.Point(260, 364);
            this.btnISA.Name = "btnISA";
            this.btnISA.Size = new System.Drawing.Size(109, 27);
            this.btnISA.TabIndex = 0;
            this.btnISA.Text = "Iniciar sesión";
            this.btnISA.UseVisualStyleBackColor = true;
            this.btnISA.Click += new System.EventHandler(this.btnISA_Click);
            // 
            // btnISC
            // 
            this.btnISC.Location = new System.Drawing.Point(525, 364);
            this.btnISC.Name = "btnISC";
            this.btnISC.Size = new System.Drawing.Size(109, 27);
            this.btnISC.TabIndex = 1;
            this.btnISC.Text = "Iniciar sesión";
            this.btnISC.UseVisualStyleBackColor = true;
            this.btnISC.Click += new System.EventHandler(this.btnISC_Click);
            // 
            // lbISA
            // 
            this.lbISA.AutoSize = true;
            this.lbISA.Location = new System.Drawing.Point(280, 245);
            this.lbISA.Name = "lbISA";
            this.lbISA.Size = new System.Drawing.Size(70, 13);
            this.lbISA.TabIndex = 2;
            this.lbISA.Text = "Administrador";
            // 
            // lbISC
            // 
            this.lbISC.AutoSize = true;
            this.lbISC.Location = new System.Drawing.Point(558, 245);
            this.lbISC.Name = "lbISC";
            this.lbISC.Size = new System.Drawing.Size(39, 13);
            this.lbISC.TabIndex = 3;
            this.lbISC.Text = "Cliente";
            // 
            // txbISAU
            // 
            this.txbISAU.Location = new System.Drawing.Point(260, 274);
            this.txbISAU.Name = "txbISAU";
            this.txbISAU.Size = new System.Drawing.Size(109, 20);
            this.txbISAU.TabIndex = 4;
            // 
            // txbISAC
            // 
            this.txbISAC.Location = new System.Drawing.Point(260, 315);
            this.txbISAC.Name = "txbISAC";
            this.txbISAC.PasswordChar = '*';
            this.txbISAC.Size = new System.Drawing.Size(109, 20);
            this.txbISAC.TabIndex = 5;
            // 
            // txbISCU
            // 
            this.txbISCU.Location = new System.Drawing.Point(525, 274);
            this.txbISCU.Name = "txbISCU";
            this.txbISCU.Size = new System.Drawing.Size(109, 20);
            this.txbISCU.TabIndex = 6;
            // 
            // txbISCC
            // 
            this.txbISCC.Location = new System.Drawing.Point(525, 315);
            this.txbISCC.Name = "txbISCC";
            this.txbISCC.PasswordChar = '*';
            this.txbISCC.Size = new System.Drawing.Size(109, 20);
            this.txbISCC.TabIndex = 7;
            // 
            // lbIS
            // 
            this.lbIS.AutoSize = true;
            this.lbIS.Location = new System.Drawing.Point(12, 242);
            this.lbIS.Name = "lbIS";
            this.lbIS.Size = new System.Drawing.Size(128, 13);
            this.lbIS.TabIndex = 8;
            this.lbIS.Text = "Inicie sesión según su rol:";
            // 
            // lbISAU
            // 
            this.lbISAU.AutoSize = true;
            this.lbISAU.Location = new System.Drawing.Point(208, 277);
            this.lbISAU.Name = "lbISAU";
            this.lbISAU.Size = new System.Drawing.Size(46, 13);
            this.lbISAU.TabIndex = 9;
            this.lbISAU.Text = "Usuario:";
            // 
            // lbISAC
            // 
            this.lbISAC.AutoSize = true;
            this.lbISAC.Location = new System.Drawing.Point(217, 318);
            this.lbISAC.Name = "lbISAC";
            this.lbISAC.Size = new System.Drawing.Size(37, 13);
            this.lbISAC.TabIndex = 10;
            this.lbISAC.Text = "Clave:";
            // 
            // lbISCU
            // 
            this.lbISCU.AutoSize = true;
            this.lbISCU.Location = new System.Drawing.Point(473, 277);
            this.lbISCU.Name = "lbISCU";
            this.lbISCU.Size = new System.Drawing.Size(46, 13);
            this.lbISCU.TabIndex = 11;
            this.lbISCU.Text = "Usuario:";
            // 
            // lbISCC
            // 
            this.lbISCC.AutoSize = true;
            this.lbISCC.Location = new System.Drawing.Point(482, 322);
            this.lbISCC.Name = "lbISCC";
            this.lbISCC.Size = new System.Drawing.Size(37, 13);
            this.lbISCC.TabIndex = 12;
            this.lbISCC.Text = "Clave:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbISCC);
            this.Controls.Add(this.lbISCU);
            this.Controls.Add(this.lbISAC);
            this.Controls.Add(this.lbISAU);
            this.Controls.Add(this.lbIS);
            this.Controls.Add(this.txbISCC);
            this.Controls.Add(this.txbISCU);
            this.Controls.Add(this.txbISAC);
            this.Controls.Add(this.txbISAU);
            this.Controls.Add(this.lbISC);
            this.Controls.Add(this.lbISA);
            this.Controls.Add(this.btnISC);
            this.Controls.Add(this.btnISA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnISA;
        private System.Windows.Forms.Button btnISC;
        private System.Windows.Forms.Label lbISA;
        private System.Windows.Forms.Label lbISC;
        private System.Windows.Forms.TextBox txbISAU;
        private System.Windows.Forms.TextBox txbISAC;
        private System.Windows.Forms.TextBox txbISCU;
        private System.Windows.Forms.TextBox txbISCC;
        private System.Windows.Forms.Label lbIS;
        private System.Windows.Forms.Label lbISAU;
        private System.Windows.Forms.Label lbISAC;
        private System.Windows.Forms.Label lbISCU;
        private System.Windows.Forms.Label lbISCC;
    }
}

