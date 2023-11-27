namespace AdminApp
{
    partial class PanelAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdmin));
            lblLogin = new Label();
            lstUsuarios = new ListBox();
            lstAdmins = new ListBox();
            btnDetalles = new Button();
            btnBorrarCliente = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(9, 111, 155);
            lblLogin.Location = new Point(396, 19);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(267, 49);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "PANEL ADMIN";
            // 
            // lstUsuarios
            // 
            lstUsuarios.Anchor = AnchorStyles.None;
            lstUsuarios.BackColor = Color.FromArgb(189, 232, 250);
            lstUsuarios.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstUsuarios.ForeColor = Color.FromArgb(9, 111, 155);
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 29;
            lstUsuarios.Location = new Point(114, 77);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(408, 468);
            lstUsuarios.TabIndex = 2;
            lstUsuarios.SelectedIndexChanged += lstUsuarios_SelectedIndexChanged;
            // 
            // lstAdmins
            // 
            lstAdmins.Anchor = AnchorStyles.None;
            lstAdmins.BackColor = Color.FromArgb(189, 232, 250);
            lstAdmins.Font = new Font("Bahnschrift", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lstAdmins.ForeColor = Color.FromArgb(9, 111, 155);
            lstAdmins.FormattingEnabled = true;
            lstAdmins.ItemHeight = 29;
            lstAdmins.Location = new Point(552, 77);
            lstAdmins.Name = "lstAdmins";
            lstAdmins.Size = new Size(408, 468);
            lstAdmins.TabIndex = 27;
            lstAdmins.SelectedIndexChanged += lstAdmins_SelectedIndexChanged;
            // 
            // btnDetalles
            // 
            btnDetalles.Anchor = AnchorStyles.None;
            btnDetalles.BackColor = Color.DeepSkyBlue;
            btnDetalles.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetalles.ForeColor = SystemColors.ButtonHighlight;
            btnDetalles.Location = new Point(218, 584);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(198, 69);
            btnDetalles.TabIndex = 29;
            btnDetalles.Text = "VER DETALLES";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnBorrarCliente
            // 
            btnBorrarCliente.Anchor = AnchorStyles.None;
            btnBorrarCliente.BackColor = Color.DeepSkyBlue;
            btnBorrarCliente.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrarCliente.ForeColor = SystemColors.ButtonHighlight;
            btnBorrarCliente.Location = new Point(657, 584);
            btnBorrarCliente.Name = "btnBorrarCliente";
            btnBorrarCliente.Size = new Size(214, 69);
            btnBorrarCliente.TabIndex = 30;
            btnBorrarCliente.Text = " ELIMINAR CUENTA";
            btnBorrarCliente.UseVisualStyleBackColor = false;
            btnBorrarCliente.Click += btnBorrarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // PanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1064, 681);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCliente);
            Controls.Add(btnDetalles);
            Controls.Add(lstAdmins);
            Controls.Add(lstUsuarios);
            Controls.Add(lblLogin);
            DoubleBuffered = true;
            Name = "PanelAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PanelAdmin";
            WindowState = FormWindowState.Maximized;
            FormClosing += PanelAdmin_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private ListBox lstUsuarios;
        private ListBox lstAdmins;
        private Button btnDetalles;
        private Button btnBorrarCliente;
        private PictureBox pictureBox1;
    }
}