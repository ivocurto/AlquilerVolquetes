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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            lblRegistrarse = new LinkLabel();
            pnlLogin = new Panel();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            pictureBox4 = new PictureBox();
            lblReClave = new Label();
            txtReClave = new TextBox();
            pictureBox3 = new PictureBox();
            lblUsusario = new Label();
            txtUsuario = new TextBox();
            lblClave = new Label();
            lblRegister = new Label();
            pictureBox1 = new PictureBox();
            txtClave = new TextBox();
            btnIngresar = new Button();
            pictureBox2 = new PictureBox();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.AutoSize = true;
            lblRegistrarse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrarse.LinkColor = Color.FromArgb(22, 173, 225);
            lblRegistrarse.Location = new Point(72, 301);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(259, 21);
            lblRegistrarse.TabIndex = 6;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿Ya tienes una cuenta? Iniciar sesión";
            lblRegistrarse.LinkClicked += lblRegistrarse_LinkClicked;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblCorreo);
            pnlLogin.Controls.Add(txtCorreo);
            pnlLogin.Controls.Add(pictureBox4);
            pnlLogin.Controls.Add(lblReClave);
            pnlLogin.Controls.Add(txtReClave);
            pnlLogin.Controls.Add(pictureBox3);
            pnlLogin.Controls.Add(lblUsusario);
            pnlLogin.Controls.Add(lblRegistrarse);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblClave);
            pnlLogin.Controls.Add(lblRegister);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(txtClave);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Location = new Point(326, 133);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(412, 414);
            pnlLogin.TabIndex = 17;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(51, 171, 215);
            lblCorreo.Enabled = false;
            lblCorreo.FlatStyle = FlatStyle.Flat;
            lblCorreo.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(119, 110);
            lblCorreo.Margin = new Padding(0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(185, 25);
            lblCorreo.TabIndex = 73;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.BackColor = Color.FromArgb(51, 171, 215);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(114, 111);
            txtCorreo.Margin = new Padding(0);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(214, 23);
            txtCorreo.TabIndex = 93;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 102);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(412, 40);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 92;
            pictureBox4.TabStop = false;
            // 
            // lblReClave
            // 
            lblReClave.AutoSize = true;
            lblReClave.BackColor = Color.FromArgb(51, 171, 215);
            lblReClave.Enabled = false;
            lblReClave.FlatStyle = FlatStyle.Flat;
            lblReClave.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblReClave.ForeColor = Color.White;
            lblReClave.Location = new Point(119, 256);
            lblReClave.Name = "lblReClave";
            lblReClave.Size = new Size(135, 25);
            lblReClave.TabIndex = 71;
            lblReClave.Text = "Repetir clave";
            // 
            // txtReClave
            // 
            txtReClave.Anchor = AnchorStyles.None;
            txtReClave.BackColor = Color.FromArgb(51, 171, 215);
            txtReClave.BorderStyle = BorderStyle.None;
            txtReClave.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtReClave.ForeColor = Color.White;
            txtReClave.Location = new Point(116, 258);
            txtReClave.Margin = new Padding(0);
            txtReClave.Name = "txtReClave";
            txtReClave.Size = new Size(214, 23);
            txtReClave.TabIndex = 90;
            txtReClave.UseSystemPasswordChar = true;
            txtReClave.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 248);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(412, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // lblUsusario
            // 
            lblUsusario.AutoSize = true;
            lblUsusario.BackColor = Color.FromArgb(51, 171, 215);
            lblUsusario.Enabled = false;
            lblUsusario.FlatStyle = FlatStyle.Flat;
            lblUsusario.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsusario.ForeColor = Color.White;
            lblUsusario.Location = new Point(119, 160);
            lblUsusario.Name = "lblUsusario";
            lblUsusario.Size = new Size(85, 25);
            lblUsusario.TabIndex = 78;
            lblUsusario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(51, 171, 215);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(114, 160);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 23);
            txtUsuario.TabIndex = 87;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = Color.FromArgb(51, 171, 215);
            lblClave.Enabled = false;
            lblClave.FlatStyle = FlatStyle.Flat;
            lblClave.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.White;
            lblClave.Location = new Point(119, 208);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(64, 25);
            lblClave.TabIndex = 76;
            lblClave.Text = "Clave";
            // 
            // lblRegister
            // 
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(22, 173, 225);
            lblRegister.Location = new Point(0, 28);
            lblRegister.Margin = new Padding(0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(412, 49);
            lblRegister.TabIndex = 13;
            lblRegister.Text = "REGISTRO";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.BackColor = Color.FromArgb(51, 171, 215);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.ForeColor = Color.White;
            txtClave.Location = new Point(116, 210);
            txtClave.Margin = new Padding(0);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(214, 23);
            txtClave.TabIndex = 84;
            txtClave.UseSystemPasswordChar = true;
            txtClave.TextChanged += textBox2_TextChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(110, 337);
            btnIngresar.Margin = new Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(188, 55);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "REGISTRARSE";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 200);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 83;
            pictureBox2.TabStop = false;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 681);
            Controls.Add(pnlLogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            FormClosing += RegistroUsuario_FormClosing;
            Load += RegistroUsuario_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtReClave;
        private LinkLabel lblRegistrarse;
        private Panel pnlLogin;
        private Label lblUsusario;
        public TextBox txtUsuario;
        private Label lblClave;
        private Label lblRegister;
        private PictureBox pictureBox1;
        public TextBox txtClave;
        private Button btnIngresar;
        private PictureBox pictureBox2;
        private Label lblCorreo;
        public TextBox textBox3;
        private PictureBox pictureBox4;
        private Label lblReClave;
        public TextBox textBox1;
        private PictureBox pictureBox3;
        public TextBox txtCorreo;
    }
}