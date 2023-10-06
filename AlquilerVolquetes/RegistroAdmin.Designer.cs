namespace AlquilerVolquetes
{
    partial class RegistroAdmin
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
            btnIngresar = new Button();
            txtReClave = new TextBox();
            txtClave = new TextBox();
            txtUsuario = new TextBox();
            txtMail = new TextBox();
            lblRegister = new Label();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkCyan;
            btnIngresar.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(823, 595);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(425, 78);
            btnIngresar.TabIndex = 17;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // txtReClave
            // 
            txtReClave.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtReClave.Location = new Point(456, 322);
            txtReClave.Margin = new Padding(3, 4, 3, 4);
            txtReClave.Name = "txtReClave";
            txtReClave.PasswordChar = '*';
            txtReClave.PlaceholderText = " Repetir contraseña";
            txtReClave.Size = new Size(376, 44);
            txtReClave.TabIndex = 21;
            // 
            // txtClave
            // 
            txtClave.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.Location = new Point(12, 322);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.PlaceholderText = " Contraseña";
            txtClave.Size = new Size(376, 44);
            txtClave.TabIndex = 20;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(456, 146);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = " Ususario";
            txtUsuario.Size = new Size(376, 44);
            txtUsuario.TabIndex = 19;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Bahnschrift Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMail.Location = new Point(12, 146);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.PlaceholderText = " Correo electrónico";
            txtMail.Size = new Size(376, 44);
            txtMail.TabIndex = 18;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Bahnschrift", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = SystemColors.Highlight;
            lblRegister.Location = new Point(3, 9);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(419, 60);
            lblRegister.TabIndex = 23;
            lblRegister.Text = "ADMIN REGISTER";
            // 
            // RegistroAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1326, 721);
            Controls.Add(btnIngresar);
            Controls.Add(txtReClave);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtMail);
            Controls.Add(lblRegister);
            Name = "RegistroAdmin";
            Text = "RegistroAdmin";
            Load += RegistroAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtReClave;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private TextBox txtMail;
        private Label lblRegister;
    }
}