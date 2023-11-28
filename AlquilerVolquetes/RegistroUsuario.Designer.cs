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
            pbCerrado = new PictureBox();
            pbAbierto = new PictureBox();
            lblApellido = new Label();
            button2 = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pbCerrado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAbierto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            lblRegistrarse.Location = new Point(94, 485);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(321, 28);
            lblRegistrarse.TabIndex = 5;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿Ya tienes una cuenta? Iniciar sesión";
            lblRegistrarse.LinkClicked += lblRegistrarse_LinkClicked;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(pbCerrado);
            pnlLogin.Controls.Add(pbAbierto);
            pnlLogin.Controls.Add(lblApellido);
            pnlLogin.Controls.Add(button2);
            pnlLogin.Controls.Add(lblNombre);
            pnlLogin.Controls.Add(txtNombre);
            pnlLogin.Controls.Add(txtApellido);
            pnlLogin.Controls.Add(pictureBox6);
            pnlLogin.Controls.Add(pictureBox5);
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
            pnlLogin.Location = new Point(371, 101);
            pnlLogin.Margin = new Padding(3, 4, 3, 4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(471, 675);
            pnlLogin.TabIndex = 7;
            // 
            // pbCerrado
            // 
            pbCerrado.BackColor = Color.Transparent;
            pbCerrado.BackgroundImage = (Image)resources.GetObject("pbCerrado.BackgroundImage");
            pbCerrado.BackgroundImageLayout = ImageLayout.Zoom;
            pbCerrado.Enabled = false;
            pbCerrado.Image = Properties.Resources.vista;
            pbCerrado.Location = new Point(191, 339);
            pbCerrado.Name = "pbCerrado";
            pbCerrado.Size = new Size(41, 43);
            pbCerrado.TabIndex = 97;
            pbCerrado.TabStop = false;
            pbCerrado.UseWaitCursor = true;
            // 
            // pbAbierto
            // 
            pbAbierto.BackColor = Color.Transparent;
            pbAbierto.BackgroundImage = Properties.Resources.vista;
            pbAbierto.BackgroundImageLayout = ImageLayout.Zoom;
            pbAbierto.Enabled = false;
            pbAbierto.Image = Properties.Resources.vista;
            pbAbierto.Location = new Point(277, 347);
            pbAbierto.Name = "pbAbierto";
            pbAbierto.Size = new Size(41, 43);
            pbAbierto.TabIndex = 96;
            pbAbierto.TabStop = false;
            pbAbierto.UseWaitCursor = true;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.FromArgb(51, 171, 215);
            lblApellido.Enabled = false;
            lblApellido.FlatStyle = FlatStyle.Flat;
            lblApellido.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(133, 171);
            lblApellido.Margin = new Padding(0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(114, 33);
            lblApellido.TabIndex = 97;
            lblApellido.Text = "Apellido";
            // 
            // button2
            // 
            button2.Location = new Point(265, 361);
            button2.Name = "button2";
            button2.Size = new Size(41, 29);
            button2.TabIndex = 95;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(51, 171, 215);
            lblNombre.Enabled = false;
            lblNombre.FlatStyle = FlatStyle.Flat;
            lblNombre.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(133, 109);
            lblNombre.Margin = new Padding(0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 33);
            lblNombre.TabIndex = 96;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.BackColor = Color.FromArgb(51, 171, 215);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(126, 112);
            txtNombre.Margin = new Padding(0);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 29);
            txtNombre.TabIndex = 95;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.BackColor = Color.FromArgb(51, 171, 215);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.ForeColor = Color.White;
            txtApellido.Location = new Point(126, 173);
            txtApellido.Margin = new Padding(0);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(245, 29);
            txtApellido.TabIndex = 94;
            txtApellido.TextChanged += txtApellido_TextChanged;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.None;
            pictureBox6.BackgroundImageLayout = ImageLayout.None;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 99);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(471, 53);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 94;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.BackgroundImageLayout = ImageLayout.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 160);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(471, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 93;
            pictureBox5.TabStop = false;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.FromArgb(51, 171, 215);
            lblCorreo.Enabled = false;
            lblCorreo.FlatStyle = FlatStyle.Flat;
            lblCorreo.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCorreo.ForeColor = Color.White;
            lblCorreo.Location = new Point(133, 233);
            lblCorreo.Margin = new Padding(0);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(242, 33);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Anchor = AnchorStyles.None;
            txtCorreo.BackColor = Color.FromArgb(51, 171, 215);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(127, 233);
            txtCorreo.Margin = new Padding(0);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(245, 29);
            txtCorreo.TabIndex = 1;
            txtCorreo.TextChanged += textBox3_TextChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 221);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(471, 53);
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
            lblReClave.Location = new Point(133, 427);
            lblReClave.Name = "lblReClave";
            lblReClave.Size = new Size(173, 33);
            lblReClave.TabIndex = 11;
            lblReClave.Text = "Repetir clave";
            // 
            // txtReClave
            // 
            txtReClave.Anchor = AnchorStyles.None;
            txtReClave.BackColor = Color.FromArgb(51, 171, 215);
            txtReClave.BorderStyle = BorderStyle.None;
            txtReClave.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtReClave.ForeColor = Color.White;
            txtReClave.Location = new Point(129, 429);
            txtReClave.Margin = new Padding(0);
            txtReClave.Name = "txtReClave";
            txtReClave.Size = new Size(245, 29);
            txtReClave.TabIndex = 4;
            txtReClave.UseSystemPasswordChar = true;
            txtReClave.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 416);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(471, 53);
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
            lblUsusario.Location = new Point(133, 299);
            lblUsusario.Name = "lblUsusario";
            lblUsusario.Size = new Size(110, 33);
            lblUsusario.TabIndex = 9;
            lblUsusario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(51, 171, 215);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(127, 299);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(245, 29);
            txtUsuario.TabIndex = 2;
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
            lblClave.Location = new Point(133, 365);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(82, 33);
            lblClave.TabIndex = 10;
            lblClave.Text = "Clave";
            // 
            // lblRegister
            // 
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(22, 173, 225);
            lblRegister.Location = new Point(0, 21);
            lblRegister.Margin = new Padding(0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(471, 65);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "REGISTRO";
            lblRegister.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 287);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 53);
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
            txtClave.Location = new Point(-70, 365);
            txtClave.Margin = new Padding(0);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(245, 29);
            txtClave.TabIndex = 3;
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
            btnIngresar.Location = new Point(126, 525);
            btnIngresar.Margin = new Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(215, 73);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "REGISTRARSE";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-55, 430);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(471, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 83;
            pictureBox2.TabStop = false;
            // 
            // RegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1216, 908);
            Controls.Add(pnlLogin);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistroUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            FormClosing += RegistroUsuario_FormClosing;
            Load += RegistroUsuario_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAbierto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private PictureBox pictureBox3;
        public TextBox txtCorreo;
        public TextBox txtApellido;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblApellido;
        private Label lblNombre;
        public TextBox txtNombre;
        private PictureBox pbCerrado;
        private PictureBox pbAbierto;
        private Button button2;
    }
}