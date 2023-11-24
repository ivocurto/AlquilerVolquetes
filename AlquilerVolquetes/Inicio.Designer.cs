namespace AlquilerVolquetes
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            lblLogin = new Label();
            lblBienvenido = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.None;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Trebuchet MS", 44F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.FromArgb(9, 111, 155);
            lblLogin.Location = new Point(-13, 122);
            lblLogin.Margin = new Padding(0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(786, 64);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "FERRURTO VOLQUETES";
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBienvenido
            // 
            lblBienvenido.Anchor = AnchorStyles.None;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.FromArgb(97, 205, 245);
            lblBienvenido.ImageAlign = ContentAlignment.MiddleLeft;
            lblBienvenido.Location = new Point(57, 71);
            lblBienvenido.Margin = new Padding(0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(460, 64);
            lblBienvenido.TabIndex = 3;
            lblBienvenido.Text = "BIENVENIDO/A ABRIL";
            lblBienvenido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 233);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1097, 494);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1155, 739);
            Controls.Add(pictureBox1);
            Controls.Add(lblBienvenido);
            Controls.Add(lblLogin);
            DoubleBuffered = true;
            Name = "Inicio";
            Text = "Inicio";
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblLogin;
        private Label lblBienvenido;
        private PictureBox pictureBox1;
    }
}