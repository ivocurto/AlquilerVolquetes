namespace AlquilerVolquetes
{
    partial class PantallaPrincipal : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            pictureBox3 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCantidadVolqueteChico = new Label();
            lblCantidadVolqueteMediano = new Label();
            lblCantidadVolqueteGrande = new Label();
            lstProductos = new ListBox();
            lblPrecioChico = new Label();
            lblPrecioMediano = new Label();
            lblPrecioGrande = new Label();
            btnAgregarAlCarrito = new Button();
            lblPrecioTotal = new Label();
            pictureBox2 = new PictureBox();
            btnCarrito = new PictureBox();
            btnSumarVC = new PictureBox();
            btnSumarVM = new PictureBox();
            btnSumarVG = new PictureBox();
            btnRestarVC = new PictureBox();
            btnRestarVM = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnRestarVG = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 465);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(231, 150);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // lblCantidadVolqueteChico
            // 
            lblCantidadVolqueteChico.Anchor = AnchorStyles.None;
            lblCantidadVolqueteChico.AutoSize = true;
            lblCantidadVolqueteChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteChico.Location = new Point(348, 171);
            lblCantidadVolqueteChico.Name = "lblCantidadVolqueteChico";
            lblCantidadVolqueteChico.Size = new Size(19, 23);
            lblCantidadVolqueteChico.TabIndex = 10;
            lblCantidadVolqueteChico.Text = "0";
            lblCantidadVolqueteChico.Click += lblCantidadVolqueteChico_Click;
            // 
            // lblCantidadVolqueteMediano
            // 
            lblCantidadVolqueteMediano.Anchor = AnchorStyles.None;
            lblCantidadVolqueteMediano.AutoSize = true;
            lblCantidadVolqueteMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteMediano.Location = new Point(348, 359);
            lblCantidadVolqueteMediano.Name = "lblCantidadVolqueteMediano";
            lblCantidadVolqueteMediano.Size = new Size(19, 23);
            lblCantidadVolqueteMediano.TabIndex = 11;
            lblCantidadVolqueteMediano.Text = "0";
            lblCantidadVolqueteMediano.Click += lblCantidadVolqueteMediano_Click;
            // 
            // lblCantidadVolqueteGrande
            // 
            lblCantidadVolqueteGrande.Anchor = AnchorStyles.None;
            lblCantidadVolqueteGrande.AutoSize = true;
            lblCantidadVolqueteGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteGrande.Location = new Point(348, 532);
            lblCantidadVolqueteGrande.Name = "lblCantidadVolqueteGrande";
            lblCantidadVolqueteGrande.Size = new Size(19, 23);
            lblCantidadVolqueteGrande.TabIndex = 12;
            lblCantidadVolqueteGrande.Text = "0";
            lblCantidadVolqueteGrande.Click += lblCantidadVolqueteGrande_Click;
            // 
            // lstProductos
            // 
            lstProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lstProductos.BackColor = Color.FromArgb(214, 241, 247);
            lstProductos.BorderStyle = BorderStyle.None;
            lstProductos.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstProductos.ForeColor = SystemColors.MenuText;
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(25, 50);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(199, 92);
            lstProductos.TabIndex = 15;
            lstProductos.DrawItem += lstProductos_DrawItem;
            // 
            // lblPrecioChico
            // 
            lblPrecioChico.Anchor = AnchorStyles.None;
            lblPrecioChico.AutoSize = true;
            lblPrecioChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioChico.Location = new Point(379, 171);
            lblPrecioChico.Name = "lblPrecioChico";
            lblPrecioChico.Size = new Size(29, 23);
            lblPrecioChico.TabIndex = 16;
            lblPrecioChico.Text = "$0";
            lblPrecioChico.UseMnemonic = false;
            lblPrecioChico.Visible = false;
            lblPrecioChico.Click += lblPrecioChico_Click;
            // 
            // lblPrecioMediano
            // 
            lblPrecioMediano.Anchor = AnchorStyles.None;
            lblPrecioMediano.AutoSize = true;
            lblPrecioMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMediano.Location = new Point(379, 359);
            lblPrecioMediano.Name = "lblPrecioMediano";
            lblPrecioMediano.Size = new Size(29, 23);
            lblPrecioMediano.TabIndex = 17;
            lblPrecioMediano.Text = "$0";
            lblPrecioMediano.Visible = false;
            lblPrecioMediano.Click += lblPrecioMediano_Click;
            // 
            // lblPrecioGrande
            // 
            lblPrecioGrande.Anchor = AnchorStyles.None;
            lblPrecioGrande.AutoSize = true;
            lblPrecioGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioGrande.Location = new Point(379, 532);
            lblPrecioGrande.Name = "lblPrecioGrande";
            lblPrecioGrande.Size = new Size(29, 23);
            lblPrecioGrande.TabIndex = 18;
            lblPrecioGrande.Text = "$0";
            lblPrecioGrande.Visible = false;
            lblPrecioGrande.Click += lblPrecioGrande_Click;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAgregarAlCarrito.BackColor = Color.DeepSkyBlue;
            btnAgregarAlCarrito.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarAlCarrito.Location = new Point(25, 199);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(199, 52);
            btnAgregarAlCarrito.TabIndex = 19;
            btnAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Bahnschrift SemiBold SemiConden", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioTotal.Location = new Point(74, 153);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(107, 25);
            lblPrecioTotal.TabIndex = 20;
            lblPrecioTotal.Text = "   TOTAL: $0";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 291);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // btnCarrito
            // 
            btnCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCarrito.Image = (Image)resources.GetObject("btnCarrito.Image");
            btnCarrito.Location = new Point(658, 22);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Padding = new Padding(5);
            btnCarrito.Size = new Size(50, 50);
            btnCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCarrito.TabIndex = 22;
            btnCarrito.TabStop = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // btnSumarVC
            // 
            btnSumarVC.Anchor = AnchorStyles.None;
            btnSumarVC.Image = (Image)resources.GetObject("btnSumarVC.Image");
            btnSumarVC.Location = new Point(306, 134);
            btnSumarVC.Name = "btnSumarVC";
            btnSumarVC.Size = new Size(35, 35);
            btnSumarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVC.TabIndex = 23;
            btnSumarVC.TabStop = false;
            btnSumarVC.Click += btnSumarVC_Click;
            // 
            // btnSumarVM
            // 
            btnSumarVM.Anchor = AnchorStyles.None;
            btnSumarVM.Image = (Image)resources.GetObject("btnSumarVM.Image");
            btnSumarVM.Location = new Point(306, 322);
            btnSumarVM.Name = "btnSumarVM";
            btnSumarVM.Size = new Size(35, 35);
            btnSumarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVM.TabIndex = 24;
            btnSumarVM.TabStop = false;
            btnSumarVM.Click += btnSumarVM_Click;
            // 
            // btnSumarVG
            // 
            btnSumarVG.Anchor = AnchorStyles.None;
            btnSumarVG.Image = (Image)resources.GetObject("btnSumarVG.Image");
            btnSumarVG.Location = new Point(306, 494);
            btnSumarVG.Name = "btnSumarVG";
            btnSumarVG.Size = new Size(35, 35);
            btnSumarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSumarVG.TabIndex = 25;
            btnSumarVG.TabStop = false;
            btnSumarVG.Click += btnSumarVG_Click;
            // 
            // btnRestarVC
            // 
            btnRestarVC.Anchor = AnchorStyles.None;
            btnRestarVC.Image = (Image)resources.GetObject("btnRestarVC.Image");
            btnRestarVC.Location = new Point(306, 190);
            btnRestarVC.Name = "btnRestarVC";
            btnRestarVC.Size = new Size(35, 35);
            btnRestarVC.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVC.TabIndex = 26;
            btnRestarVC.TabStop = false;
            btnRestarVC.Click += btnRestarVC_Click;
            // 
            // btnRestarVM
            // 
            btnRestarVM.Anchor = AnchorStyles.None;
            btnRestarVM.Image = (Image)resources.GetObject("btnRestarVM.Image");
            btnRestarVM.Location = new Point(306, 378);
            btnRestarVM.Name = "btnRestarVM";
            btnRestarVM.Size = new Size(35, 35);
            btnRestarVM.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVM.TabIndex = 27;
            btnRestarVM.TabStop = false;
            btnRestarVM.Click += btnRestarVM_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(214, 241, 247);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnRestarVG);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnRestarVM);
            panel1.Controls.Add(lblCantidadVolqueteChico);
            panel1.Controls.Add(btnRestarVC);
            panel1.Controls.Add(lblCantidadVolqueteMediano);
            panel1.Controls.Add(btnSumarVG);
            panel1.Controls.Add(lblCantidadVolqueteGrande);
            panel1.Controls.Add(btnSumarVM);
            panel1.Controls.Add(lblPrecioChico);
            panel1.Controls.Add(btnSumarVC);
            panel1.Controls.Add(lblPrecioMediano);
            panel1.Controls.Add(lblPrecioGrande);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 720);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnRestarVG
            // 
            btnRestarVG.Anchor = AnchorStyles.None;
            btnRestarVG.Image = (Image)resources.GetObject("btnRestarVG.Image");
            btnRestarVG.Location = new Point(306, 550);
            btnRestarVG.Name = "btnRestarVG";
            btnRestarVG.Size = new Size(35, 35);
            btnRestarVG.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRestarVG.TabIndex = 28;
            btnRestarVG.TabStop = false;
            btnRestarVG.Click += btnRestarVG_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(lblPrecioTotal);
            panel2.Controls.Add(btnAgregarAlCarrito);
            panel2.Controls.Add(lstProductos);
            panel2.Location = new Point(484, 454);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 266);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 241, 247);
            ClientSize = new Size(730, 720);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCarrito);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlquilarVolquetes";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCantidadVolqueteChico;
        private Label lblCantidadVolqueteMediano;
        private Label lblCantidadVolqueteGrande;
        private Button btnAgregarAlCarrito;
        private ListBox lstProductos;
        private Label lblPrecioChico;
        private Label lblPrecioMediano;
        private Label lblPrecioGrande;
        private Button btnIngresar;
        private Label lblPrecioTotal;
        private PictureBox pictureBox2;
        private PictureBox btnCarrito;
        private PictureBox btnSumarVC;
        private PictureBox btnSumarVM;
        private PictureBox btnSumarVG;
        private PictureBox btnRestarVC;
        private PictureBox btnRestarVM;
        private PictureBox btnRestarVG;
        private Panel panel1;
        private Panel panel2;
    }
}