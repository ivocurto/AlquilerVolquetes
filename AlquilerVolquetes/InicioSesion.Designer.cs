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
            lblNombre = new Label();
            lblClave = new Label();
            txtClave = new TextBox();
            lblRegistrarse = new LinkLabel();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(351, 151);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(210, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(351, 127);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Ususario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(351, 219);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(83, 20);
            lblClave.TabIndex = 2;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(351, 243);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(210, 27);
            txtClave.TabIndex = 3;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Location = new Point(351, 291);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(233, 20);
            lblRegistrarse.TabIndex = 4;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿No tienes una cuenta? Registrate";
            lblRegistrarse.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(410, 356);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 31);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnIngresar);
            Controls.Add(lblRegistrarse);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InicioSesion";
            Text = "InicioSesion";
            FormClosing += InicioSesion_FormClosing;
            FormClosed += InicioSesion_FormClosed;
            Load += InicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label lblNombre;
        private Label lblClave;
        private TextBox txtClave;
        private LinkLabel lblRegistrarse;
        private Button btnIngresar;
    }
}