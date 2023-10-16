namespace AlquilerVolquetes
{
    partial class InicioSesion
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
            txtUsuario = new TextBox();
            lblLogin = new Label();
            lblRegistrarse = new LinkLabel();
            btnIngresar = new Button();
            txtClave = new TextBox();
            cbAutoLogin = new CheckBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(386, 225);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Usuario";
            txtUsuario.Size = new Size(318, 36);
            txtUsuario.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.ControlDarkDark;
            lblLogin.Location = new Point(386, 150);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(308, 48);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "INICIAR SESIÓN";
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrarse.LinkColor = Color.DimGray;
            lblRegistrarse.Location = new Point(386, 352);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(244, 21);
            lblRegistrarse.TabIndex = 4;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿No tienes una cuenta? Registrate";
            lblRegistrarse.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DeepSkyBlue;
            btnIngresar.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(386, 430);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(318, 55);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(386, 295);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = " Contraseña";
            txtClave.Size = new Size(318, 36);
            txtClave.TabIndex = 3;
            // 
            // cbAutoLogin
            // 
            cbAutoLogin.AutoSize = true;
            cbAutoLogin.Location = new Point(386, 394);
            cbAutoLogin.Margin = new Padding(3, 2, 3, 2);
            cbAutoLogin.Name = "cbAutoLogin";
            cbAutoLogin.Size = new Size(173, 19);
            cbAutoLogin.TabIndex = 5;
            cbAutoLogin.Text = "Mantener inicio automático";
            cbAutoLogin.UseVisualStyleBackColor = true;
            cbAutoLogin.CheckedChanged += cbAutoLogin_CheckedChanged;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(cbAutoLogin);
            Controls.Add(txtClave);
            Controls.Add(btnIngresar);
            Controls.Add(lblRegistrarse);
            Controls.Add(lblLogin);
            Controls.Add(txtUsuario);
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            FormClosing += InicioSesion_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label lblLogin;
        private LinkLabel lblRegistrarse;
        private Button btnIngresar;
        private TextBox txtClave;
        private CheckBox cbAutoLogin;
    }
}