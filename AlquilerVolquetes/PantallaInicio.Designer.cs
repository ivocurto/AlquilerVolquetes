namespace AlquilerVolquetes
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            panelSideMenu = new Panel();
            btnCerrarSesion = new Button();
            btnAlquilar = new Button();
            btnMisVolquetes = new Button();
            btnInicio = new Button();
            panelLogo = new Panel();
            lblNombreUsuario = new Label();
            pictureBox1 = new PictureBox();
            panelContenedor = new Panel();
            panelSideMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(26, 157, 192);
            panelSideMenu.Controls.Add(btnCerrarSesion);
            panelSideMenu.Controls.Add(btnAlquilar);
            panelSideMenu.Controls.Add(btnMisVolquetes);
            panelSideMenu.Controls.Add(btnInicio);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Margin = new Padding(4, 3, 4, 3);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(350, 681);
            panelSideMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Top;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 102, 131);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 102, 131);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = Color.Gainsboro;
            btnCerrarSesion.Location = new Point(0, 265);
            btnCerrarSesion.Margin = new Padding(4, 3, 4, 3);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(25, 0, 0, 0);
            btnCerrarSesion.Size = new Size(350, 51);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAlquilar
            // 
            btnAlquilar.Dock = DockStyle.Top;
            btnAlquilar.FlatAppearance.BorderSize = 0;
            btnAlquilar.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 102, 131);
            btnAlquilar.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 102, 131);
            btnAlquilar.FlatStyle = FlatStyle.Flat;
            btnAlquilar.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAlquilar.ForeColor = Color.Gainsboro;
            btnAlquilar.Location = new Point(0, 214);
            btnAlquilar.Margin = new Padding(4, 3, 4, 3);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Padding = new Padding(25, 0, 0, 0);
            btnAlquilar.Size = new Size(350, 51);
            btnAlquilar.TabIndex = 3;
            btnAlquilar.Text = "Alquilar volquetes";
            btnAlquilar.TextAlign = ContentAlignment.MiddleLeft;
            btnAlquilar.UseVisualStyleBackColor = true;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // btnMisVolquetes
            // 
            btnMisVolquetes.Dock = DockStyle.Top;
            btnMisVolquetes.FlatAppearance.BorderSize = 0;
            btnMisVolquetes.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 102, 131);
            btnMisVolquetes.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 102, 131);
            btnMisVolquetes.FlatStyle = FlatStyle.Flat;
            btnMisVolquetes.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMisVolquetes.ForeColor = Color.Gainsboro;
            btnMisVolquetes.Location = new Point(0, 163);
            btnMisVolquetes.Margin = new Padding(4, 3, 4, 3);
            btnMisVolquetes.Name = "btnMisVolquetes";
            btnMisVolquetes.Padding = new Padding(25, 0, 0, 0);
            btnMisVolquetes.Size = new Size(350, 51);
            btnMisVolquetes.TabIndex = 2;
            btnMisVolquetes.Text = "Mis volquetes";
            btnMisVolquetes.TextAlign = ContentAlignment.MiddleLeft;
            btnMisVolquetes.UseVisualStyleBackColor = true;
            btnMisVolquetes.Click += btnMisVolquetes_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 102, 131);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 102, 131);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.Gainsboro;
            btnInicio.Location = new Point(0, 112);
            btnInicio.Margin = new Padding(4, 3, 4, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(25, 0, 0, 0);
            btnInicio.Size = new Size(350, 51);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblNombreUsuario);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(4, 3, 4, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(350, 112);
            panelLogo.TabIndex = 0;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(62, 30);
            lblNombreUsuario.Margin = new Padding(0);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(267, 49);
            lblNombreUsuario.TabIndex = 51;
            lblNombreUsuario.Text = "Nombre_usuario";
            lblNombreUsuario.TextAlign = ContentAlignment.MiddleLeft;
            lblNombreUsuario.TextChanged += lblLogin_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(61, 188, 219);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(350, 0);
            panelContenedor.MinimumSize = new Size(714, 681);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(714, 681);
            panelContenedor.TabIndex = 2;
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(panelContenedor);
            Controls.Add(panelSideMenu);
            Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(950, 600);
            Name = "PantallaInicio";
            StartPosition = FormStartPosition.Manual;
            Text = "Inicio";
            FormClosing += PantallaInicio_FormClosing;
            Load += PantallaInicio_Load;
            panelSideMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Button btnInicio;
        private Panel panelLogo;
        private Button btnCerrarSesion;
        private Button btnAlquilar;
        private Button btnMisVolquetes;
        private Panel panelContenedor;
        private PictureBox pictureBox1;
        private Label lblNombreUsuario;
    }
}