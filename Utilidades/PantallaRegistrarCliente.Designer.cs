namespace ProStore
{
    partial class PantallaRegistrarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodClie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirecClie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelClie = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelClie = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApeClie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreClie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(479, 100);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(479, 160);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(479, 220);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.txtCodClie);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDirecClie);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCelClie);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTelClie);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCedCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtApeClie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombreClie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 384);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtCodClie
            // 
            this.txtCodClie.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodClie.Location = new System.Drawing.Point(204, 343);
            this.txtCodClie.MaxLength = 60;
            this.txtCodClie.Name = "txtCodClie";
            this.txtCodClie.ReadOnly = true;
            this.txtCodClie.Size = new System.Drawing.Size(200, 22);
            this.txtCodClie.TabIndex = 6;
            this.txtCodClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(13, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 26);
            this.label8.TabIndex = 40;
            this.label8.Text = "Codigo Cliente:";
            // 
            // txtDirecClie
            // 
            this.txtDirecClie.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirecClie.Location = new System.Drawing.Point(204, 302);
            this.txtDirecClie.MaxLength = 50;
            this.txtDirecClie.Name = "txtDirecClie";
            this.txtDirecClie.Size = new System.Drawing.Size(200, 22);
            this.txtDirecClie.TabIndex = 5;
            this.txtDirecClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(13, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 26);
            this.label7.TabIndex = 38;
            this.label7.Text = "Dirección Cliente:";
            // 
            // txtCelClie
            // 
            this.txtCelClie.Location = new System.Drawing.Point(204, 262);
            this.txtCelClie.Mask = "(999) 000-0000";
            this.txtCelClie.Name = "txtCelClie";
            this.txtCelClie.Size = new System.Drawing.Size(200, 20);
            this.txtCelClie.TabIndex = 4;
            this.txtCelClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(13, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 26);
            this.label6.TabIndex = 36;
            this.label6.Text = "Celular Cliente:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(18, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 10);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 47);
            this.label1.TabIndex = 33;
            this.label1.Text = "Registar Cliente";
            // 
            // txtTelClie
            // 
            this.txtTelClie.Location = new System.Drawing.Point(204, 222);
            this.txtTelClie.Mask = "(999) 000-0000";
            this.txtTelClie.Name = "txtTelClie";
            this.txtTelClie.Size = new System.Drawing.Size(200, 20);
            this.txtTelClie.TabIndex = 3;
            this.txtTelClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(13, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "Teléfono Cliente:";
            // 
            // txtCedCliente
            // 
            this.txtCedCliente.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedCliente.Location = new System.Drawing.Point(204, 176);
            this.txtCedCliente.MaxLength = 11;
            this.txtCedCliente.Name = "txtCedCliente";
            this.txtCedCliente.Size = new System.Drawing.Size(200, 22);
            this.txtCedCliente.TabIndex = 2;
            this.txtCedCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCedCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedCliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 26);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cédula/RNC Cliente:";
            // 
            // txtApeClie
            // 
            this.txtApeClie.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeClie.Location = new System.Drawing.Point(204, 132);
            this.txtApeClie.MaxLength = 60;
            this.txtApeClie.Name = "txtApeClie";
            this.txtApeClie.Size = new System.Drawing.Size(200, 22);
            this.txtApeClie.TabIndex = 1;
            this.txtApeClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 26);
            this.label3.TabIndex = 30;
            this.label3.Text = "Apellidos Cliente:";
            // 
            // txtNombreClie
            // 
            this.txtNombreClie.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClie.Location = new System.Drawing.Point(204, 88);
            this.txtNombreClie.MaxLength = 50;
            this.txtNombreClie.Name = "txtNombreClie";
            this.txtNombreClie.Size = new System.Drawing.Size(200, 22);
            this.txtNombreClie.TabIndex = 0;
            this.txtNombreClie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreClie.TextChanged += new System.EventHandler(this.txtNombreClie_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre Cliente:";
            // 
            // PantallaRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 410);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaRegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaRegistrarCliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtTelClie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApeClie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreClie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirecClie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCelClie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCedCliente;
        private System.Windows.Forms.TextBox txtCodClie;
        private System.Windows.Forms.Label label8;
    }
}