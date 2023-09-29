namespace AlquilerVolquetes
{
    partial class RegistroUsuario
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
            txtClave = new TextBox();
            lblClave = new Label();
            lblNombre = new Label();
            txtUsuario = new TextBox();
            txtReClave = new TextBox();
            lblReClave = new Label();
            lblMail = new Label();
            txtMail = new TextBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(607, 395);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(280, 271);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(210, 27);
            txtClave.TabIndex = 9;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(280, 247);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(83, 20);
            lblClave.TabIndex = 8;
            lblClave.Text = "Contraseña";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(280, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Ususario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(280, 179);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtReClave
            // 
            txtReClave.Location = new Point(280, 345);
            txtReClave.Margin = new Padding(3, 4, 3, 4);
            txtReClave.Name = "txtReClave";
            txtReClave.Size = new Size(210, 27);
            txtReClave.TabIndex = 15;
            // 
            // lblReClave
            // 
            lblReClave.AutoSize = true;
            lblReClave.Location = new Point(280, 321);
            lblReClave.Name = "lblReClave";
            lblReClave.Size = new Size(152, 20);
            lblReClave.TabIndex = 14;
            lblReClave.Text = "Reingrese Contraseña";
            lblReClave.Click += label1_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(280, 63);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(52, 20);
            lblMail.TabIndex = 13;
            lblMail.Text = "E-Mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(280, 87);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(210, 27);
            txtMail.TabIndex = 12;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtReClave);
            Controls.Add(lblReClave);
            Controls.Add(lblMail);
            Controls.Add(txtMail);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Controls.Add(txtUsuario);
            Name = "RegistroUsuario";
            Text = "Form1";
            Load += RegistroUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private TextBox txtClave;
        private Label lblClave;
        private Label lblNombre;
        private TextBox txtUsuario;
        private TextBox txtReClave;
        private Label lblReClave;
        private Label lblMail;
        private TextBox txtMail;
    }
}