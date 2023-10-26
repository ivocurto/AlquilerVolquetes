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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioSesion));
            pictureBox2 = new PictureBox();
            cbAutoLogin = new CheckBox();
            btnIngresar = new Button();
            lblRegistrarse = new LinkLabel();
            txtClave = new TextBox();
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            lblClave = new Label();
            txtUsuario = new TextBox();
            lblUsusario = new Label();
            pnlLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 192);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(412, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 83;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // cbAutoLogin
            // 
            cbAutoLogin.Anchor = AnchorStyles.None;
            cbAutoLogin.AutoSize = true;
            cbAutoLogin.ForeColor = Color.FromArgb(22, 173, 225);
            cbAutoLogin.Location = new Point(117, 359);
            cbAutoLogin.Margin = new Padding(3, 2, 3, 2);
            cbAutoLogin.Name = "cbAutoLogin";
            cbAutoLogin.Size = new Size(173, 19);
            cbAutoLogin.TabIndex = 5;
            cbAutoLogin.Text = "Mantener inicio automático";
            cbAutoLogin.UseVisualStyleBackColor = true;
            cbAutoLogin.CheckedChanged += cbAutoLogin_CheckedChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Anchor = AnchorStyles.None;
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.None;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(113, 293);
            btnIngresar.Margin = new Padding(0);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(188, 55);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblRegistrarse
            // 
            lblRegistrarse.Anchor = AnchorStyles.None;
            lblRegistrarse.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegistrarse.LinkColor = Color.FromArgb(22, 173, 225);
            lblRegistrarse.Location = new Point(0, 256);
            lblRegistrarse.Name = "lblRegistrarse";
            lblRegistrarse.Size = new Size(412, 21);
            lblRegistrarse.TabIndex = 4;
            lblRegistrarse.TabStop = true;
            lblRegistrarse.Text = "¿No tienes una cuenta? Registrate";
            lblRegistrarse.TextAlign = ContentAlignment.MiddleCenter;
            lblRegistrarse.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.None;
            txtClave.BackColor = Color.FromArgb(51, 171, 215);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtClave.ForeColor = Color.White;
            txtClave.Location = new Point(113, 202);
            txtClave.Margin = new Padding(0);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(214, 23);
            txtClave.TabIndex = 84;
            txtClave.UseSystemPasswordChar = true;
            txtClave.TextChanged += txtClave_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 126);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(22, 173, 225);
            lblLogin.Location = new Point(0, 48);
            lblLogin.Margin = new Padding(0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(412, 49);
            lblLogin.TabIndex = 13;
            lblLogin.Text = "INICIAR SESIÓN";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            lblLogin.Click += lblLogin_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.BackColor = Color.FromArgb(51, 171, 215);
            lblClave.FlatStyle = FlatStyle.Flat;
            lblClave.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClave.ForeColor = Color.White;
            lblClave.Location = new Point(111, 200);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(64, 25);
            lblClave.TabIndex = 86;
            lblClave.Text = "Clave";
            lblClave.Click += label1_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(51, 171, 215);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Bahnschrift Light", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(111, 135);
            txtUsuario.Margin = new Padding(0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(214, 23);
            txtUsuario.TabIndex = 87;
            txtUsuario.TextChanged += txtUsuario_TextChanged_1;
            // 
            // lblUsusario
            // 
            lblUsusario.AutoSize = true;
            lblUsusario.BackColor = Color.FromArgb(51, 171, 215);
            lblUsusario.FlatStyle = FlatStyle.Flat;
            lblUsusario.Font = new Font("Bahnschrift SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsusario.ForeColor = Color.White;
            lblUsusario.Location = new Point(113, 134);
            lblUsusario.Name = "lblUsusario";
            lblUsusario.Size = new Size(85, 25);
            lblUsusario.TabIndex = 88;
            lblUsusario.Text = "Usuario";
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.None;
            pnlLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblUsusario);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblClave);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(txtClave);
            pnlLogin.Controls.Add(lblRegistrarse);
            pnlLogin.Controls.Add(btnIngresar);
            pnlLogin.Controls.Add(cbAutoLogin);
            pnlLogin.Controls.Add(pictureBox2);
            pnlLogin.Location = new Point(325, 135);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(412, 414);
            pnlLogin.TabIndex = 6;
            pnlLogin.Paint += panel1_Paint;
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 681);
            Controls.Add(pnlLogin);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "InicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            FormClosing += InicioSesion_FormClosing;
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private CheckBox cbAutoLogin;
        private Button btnIngresar;
        private LinkLabel lblRegistrarse;
        public TextBox txtClave;
        private PictureBox pictureBox1;
        private Label lblLogin;
        private Label lblClave;
        public TextBox txtUsuario;
        private Label lblUsusario;
        private Panel pnlLogin;
    }
}