namespace ProStore
{
    partial class PantallaLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuLogin = new System.Windows.Forms.TextBox();
            this.txtContraLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciarSesi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F);
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProStore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUsuLogin
            // 
            this.txtUsuLogin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuLogin.Location = new System.Drawing.Point(152, 115);
            this.txtUsuLogin.Name = "txtUsuLogin";
            this.txtUsuLogin.Size = new System.Drawing.Size(183, 22);
            this.txtUsuLogin.TabIndex = 0;
            this.txtUsuLogin.TextChanged += new System.EventHandler(this.txtUsuLogin_TextChanged);
            // 
            // txtContraLogin
            // 
            this.txtContraLogin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraLogin.Location = new System.Drawing.Point(152, 160);
            this.txtContraLogin.Name = "txtContraLogin";
            this.txtContraLogin.PasswordChar = '*';
            this.txtContraLogin.Size = new System.Drawing.Size(183, 22);
            this.txtContraLogin.TabIndex = 1;
            this.txtContraLogin.TextChanged += new System.EventHandler(this.txtContraLogin_TextChanged);
            this.txtContraLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraLogin_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnIniciarSesi
            // 
            this.btnIniciarSesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesi.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesi.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnIniciarSesi.Location = new System.Drawing.Point(106, 234);
            this.btnIniciarSesi.Name = "btnIniciarSesi";
            this.btnIniciarSesi.Size = new System.Drawing.Size(104, 36);
            this.btnIniciarSesi.TabIndex = 2;
            this.btnIniciarSesi.Text = "Iniciar Sesion";
            this.btnIniciarSesi.UseVisualStyleBackColor = true;
            this.btnIniciarSesi.Click += new System.EventHandler(this.btnIniciarSesi_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(231, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(434, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIniciarSesi);
            this.Controls.Add(this.txtContraLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "PantallaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuLogin;
        private System.Windows.Forms.TextBox txtContraLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciarSesi;
        private System.Windows.Forms.Button button1;
    }
}

