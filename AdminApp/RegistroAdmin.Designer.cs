namespace AdminApp
{
    partial class RegistroAdmin
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

        private void InitializeComponent()
        {
            lblRegister = new Label();
            txtMail = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            txtReClave = new TextBox();
            btnIngresar = new Button();
            lblRegistrarse = new LinkLabel();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = SystemColors.ControlDarkDark;
            lblRegister.Location = new Point(376, 116);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(332, 48);
            lblRegister.TabIndex = 16;
            lblRegister.Text = "GENERAR ADMIN";
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(386, 189);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = " Correo electrónico";
            txtMail.Size = new Size(318, 36);
            txtMail.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(386, 259);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Ususario";
            txtUsuario.Size = new Size(318, 36);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(386, 329);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = " Contraseña";
            txtClave.Size = new Size(318, 36);
            txtClave.TabIndex = 4;
            // 
            // txtReClave
            // 
            txtReClave.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtReClave.Location = new Point(386, 399);
            txtReClave.Name = "txtReClave";
            txtReClave.PasswordChar = '*';
            txtReClave.PlaceholderText = " Repetir contraseña";
            txtReClave.Size = new Size(318, 36);
            txtReClave.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DeepSkyBlue;
            btnIngresar.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(386, 501);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(318, 55);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "GENERAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrarse.LinkColor = Color.DimGray;
            lblRegistrarse.Location = new Point(604, 461);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(100, 21);
            lblRegistrarse.TabIndex = 6;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "Iniciar sesión";
            lblRegistrarse.LinkClicked += lblRegistrarse_LinkClicked;
            // 
            // RegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(lblRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(txtReClave);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtMail);
            Controls.Add(lblRegister);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            FormClosed += RegistroAdmin_FormClosed;
            Load += RegistroAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRegister;
        private TextBox txtMail;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private TextBox txtReClave;
        private Button btnIngresar;
        private LinkLabel lblRegistrarse;
    }


}