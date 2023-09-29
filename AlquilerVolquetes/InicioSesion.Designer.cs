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
            txtUsuario.Location = new Point(307, 113);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(184, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(307, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Ususario";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(307, 164);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(67, 15);
            lblClave.TabIndex = 2;
            lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(307, 182);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(184, 23);
            txtClave.TabIndex = 3;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Location = new Point(307, 218);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(184, 15);
            lblRegistrarse.TabIndex = 4;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿No tienes una cuenta? Registrate";
            lblRegistrarse.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(359, 267);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(lblRegistrarse);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(lblNombre);
            Controls.Add(txtUsuario);
            Name = "InicioSesion";
            Text = "InicioSesion";
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