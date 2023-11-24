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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lstProductos = new ListBox();
            btnAgregarAlCarrito = new Button();
            btnCarrito = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnRestarVG = new PictureBox();
            pictureBox3 = new PictureBox();
            btnRestarVM = new PictureBox();
            lblCantidadVolqueteChico = new Label();
            btnRestarVC = new PictureBox();
            lblCantidadVolqueteMediano = new Label();
            btnSumarVG = new PictureBox();
            lblCantidadVolqueteGrande = new Label();
            btnSumarVM = new PictureBox();
            lblPrecioChico = new Label();
            btnSumarVC = new PictureBox();
            lblPrecioMediano = new Label();
            lblPrecioGrande = new Label();
            pictureBox2 = new PictureBox();
            lblVolqueteM = new Label();
            lblVolqueteC = new Label();
            lblVolqueteG = new Label();
            lblStockVC = new Label();
            lblStockVM = new Label();
            lblStockVG = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)btnCarrito).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstProductos
            // 
            lstProductos.Anchor = AnchorStyles.Bottom;
            lstProductos.BackColor = Color.FromArgb(189, 232, 250);
            lstProductos.BorderStyle = BorderStyle.None;
            lstProductos.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lstProductos.ForeColor = Color.White;
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(31, 36);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(343, 92);
            lstProductos.TabIndex = 15;
            lstProductos.DrawItem += lstProductos_DrawItem;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Anchor = AnchorStyles.Bottom;
            btnAgregarAlCarrito.BackColor = Color.DeepSkyBlue;
            btnAgregarAlCarrito.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = SystemColors.ButtonHighlight;
            btnAgregarAlCarrito.Location = new Point(106, 154);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(199, 52);
            btnAgregarAlCarrito.TabIndex = 19;
            btnAgregarAlCarrito.Text = "AGREGAR AL CARRITO";
            btnAgregarAlCarrito.UseVisualStyleBackColor = false;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // btnCarrito
            // 
            btnCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCarrito.BackColor = Color.Transparent;
            btnCarrito.Image = (Image)resources.GetObject("btnCarrito.Image");
            btnCarrito.Location = new Point(1249, 22);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Padding = new Padding(5);
            btnCarrito.Size = new Size(50, 50);
            btnCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCarrito.TabIndex = 22;
            btnCarrito.TabStop = false;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnAgregarAlCarrito);
            panel2.Controls.Add(lstProductos);
            panel2.Location = new Point(457, 454);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 266);
            panel2.TabIndex = 30;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btnRestarVG
            // 
            btnRestarVG.Anchor = AnchorStyles.None;
            btnRestarVG.Image = (Image)resources.GetObject("btnRestarVG.Image");
            btnRestarVG.Location = new Point(935, 283);
            btnRestarVG.Name = "btnRestarVG";
            btnRestarVG.Size = new Size(32, 32);
            btnRestarVG.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRestarVG.TabIndex = 45;
            btnRestarVG.TabStop = false;
            btnRestarVG.Click += btnRestarVG_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(830, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(338, 208);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // btnRestarVM
            // 
            btnRestarVM.Anchor = AnchorStyles.None;
            btnRestarVM.Image = (Image)resources.GetObject("btnRestarVM.Image");
            btnRestarVM.Location = new Point(533, 283);
            btnRestarVM.Name = "btnRestarVM";
            btnRestarVM.Size = new Size(32, 32);
            btnRestarVM.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRestarVM.TabIndex = 44;
            btnRestarVM.TabStop = false;
            btnRestarVM.Click += btnRestarVM_Click_1;
            // 
            // lblCantidadVolqueteChico
            // 
            lblCantidadVolqueteChico.Anchor = AnchorStyles.None;
            lblCantidadVolqueteChico.AutoSize = true;
            lblCantidadVolqueteChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteChico.ForeColor = Color.FromArgb(9, 111, 155);
            lblCantidadVolqueteChico.Location = new Point(190, 295);
            lblCantidadVolqueteChico.Name = "lblCantidadVolqueteChico";
            lblCantidadVolqueteChico.Size = new Size(19, 23);
            lblCantidadVolqueteChico.TabIndex = 33;
            lblCantidadVolqueteChico.Text = "0";
            // 
            // btnRestarVC
            // 
            btnRestarVC.Anchor = AnchorStyles.None;
            btnRestarVC.Image = (Image)resources.GetObject("btnRestarVC.Image");
            btnRestarVC.Location = new Point(119, 283);
            btnRestarVC.Name = "btnRestarVC";
            btnRestarVC.Size = new Size(32, 32);
            btnRestarVC.SizeMode = PictureBoxSizeMode.AutoSize;
            btnRestarVC.TabIndex = 43;
            btnRestarVC.TabStop = false;
            btnRestarVC.Click += btnRestarVC_Click_1;
            // 
            // lblCantidadVolqueteMediano
            // 
            lblCantidadVolqueteMediano.Anchor = AnchorStyles.None;
            lblCantidadVolqueteMediano.AutoSize = true;
            lblCantidadVolqueteMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteMediano.ForeColor = Color.FromArgb(9, 111, 155);
            lblCantidadVolqueteMediano.Location = new Point(607, 295);
            lblCantidadVolqueteMediano.Name = "lblCantidadVolqueteMediano";
            lblCantidadVolqueteMediano.Size = new Size(19, 23);
            lblCantidadVolqueteMediano.TabIndex = 34;
            lblCantidadVolqueteMediano.Text = "0";
            // 
            // btnSumarVG
            // 
            btnSumarVG.Anchor = AnchorStyles.None;
            btnSumarVG.Image = (Image)resources.GetObject("btnSumarVG.Image");
            btnSumarVG.Location = new Point(1052, 283);
            btnSumarVG.Name = "btnSumarVG";
            btnSumarVG.Size = new Size(32, 32);
            btnSumarVG.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSumarVG.TabIndex = 42;
            btnSumarVG.TabStop = false;
            btnSumarVG.Click += btnSumarVG_Click_1;
            // 
            // lblCantidadVolqueteGrande
            // 
            lblCantidadVolqueteGrande.Anchor = AnchorStyles.None;
            lblCantidadVolqueteGrande.AutoSize = true;
            lblCantidadVolqueteGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadVolqueteGrande.ForeColor = Color.FromArgb(9, 111, 155);
            lblCantidadVolqueteGrande.Location = new Point(1003, 295);
            lblCantidadVolqueteGrande.Name = "lblCantidadVolqueteGrande";
            lblCantidadVolqueteGrande.Size = new Size(19, 23);
            lblCantidadVolqueteGrande.TabIndex = 35;
            lblCantidadVolqueteGrande.Text = "0";
            // 
            // btnSumarVM
            // 
            btnSumarVM.Anchor = AnchorStyles.None;
            btnSumarVM.Image = (Image)resources.GetObject("btnSumarVM.Image");
            btnSumarVM.Location = new Point(657, 283);
            btnSumarVM.Name = "btnSumarVM";
            btnSumarVM.Size = new Size(32, 32);
            btnSumarVM.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSumarVM.TabIndex = 41;
            btnSumarVM.TabStop = false;
            btnSumarVM.Click += btnSumarVM_Click_1;
            // 
            // lblPrecioChico
            // 
            lblPrecioChico.Anchor = AnchorStyles.None;
            lblPrecioChico.AutoSize = true;
            lblPrecioChico.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioChico.ForeColor = Color.White;
            lblPrecioChico.Location = new Point(180, 331);
            lblPrecioChico.Name = "lblPrecioChico";
            lblPrecioChico.Size = new Size(29, 23);
            lblPrecioChico.TabIndex = 36;
            lblPrecioChico.Text = "$0";
            lblPrecioChico.UseMnemonic = false;
            lblPrecioChico.Visible = false;
            // 
            // btnSumarVC
            // 
            btnSumarVC.Anchor = AnchorStyles.None;
            btnSumarVC.Image = (Image)resources.GetObject("btnSumarVC.Image");
            btnSumarVC.Location = new Point(245, 283);
            btnSumarVC.Name = "btnSumarVC";
            btnSumarVC.Size = new Size(32, 32);
            btnSumarVC.SizeMode = PictureBoxSizeMode.AutoSize;
            btnSumarVC.TabIndex = 40;
            btnSumarVC.TabStop = false;
            btnSumarVC.Click += btnSumarVC_Click;
            // 
            // lblPrecioMediano
            // 
            lblPrecioMediano.Anchor = AnchorStyles.None;
            lblPrecioMediano.AutoSize = true;
            lblPrecioMediano.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioMediano.ForeColor = Color.White;
            lblPrecioMediano.Location = new Point(597, 331);
            lblPrecioMediano.Name = "lblPrecioMediano";
            lblPrecioMediano.Size = new Size(29, 23);
            lblPrecioMediano.TabIndex = 37;
            lblPrecioMediano.Text = "$0";
            lblPrecioMediano.Visible = false;
            // 
            // lblPrecioGrande
            // 
            lblPrecioGrande.Anchor = AnchorStyles.None;
            lblPrecioGrande.AutoSize = true;
            lblPrecioGrande.Font = new Font("Bahnschrift SemiCondensed", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioGrande.ForeColor = Color.White;
            lblPrecioGrande.Location = new Point(993, 331);
            lblPrecioGrande.Name = "lblPrecioGrande";
            lblPrecioGrande.Size = new Size(29, 23);
            lblPrecioGrande.TabIndex = 38;
            lblPrecioGrande.Text = "$0";
            lblPrecioGrande.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(428, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 208);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // lblVolqueteM
            // 
            lblVolqueteM.Anchor = AnchorStyles.None;
            lblVolqueteM.AutoSize = true;
            lblVolqueteM.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteM.ForeColor = Color.FromArgb(9, 111, 155);
            lblVolqueteM.Location = new Point(522, 241);
            lblVolqueteM.Name = "lblVolqueteM";
            lblVolqueteM.Size = new Size(178, 30);
            lblVolqueteM.TabIndex = 46;
            lblVolqueteM.Text = "Volquete Mediano";
            lblVolqueteM.TextAlign = ContentAlignment.TopRight;
            lblVolqueteM.UseCompatibleTextRendering = true;
            // 
            // lblVolqueteC
            // 
            lblVolqueteC.Anchor = AnchorStyles.None;
            lblVolqueteC.AutoSize = true;
            lblVolqueteC.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteC.ForeColor = Color.FromArgb(9, 111, 155);
            lblVolqueteC.Location = new Point(117, 241);
            lblVolqueteC.Name = "lblVolqueteC";
            lblVolqueteC.Size = new Size(151, 30);
            lblVolqueteC.TabIndex = 47;
            lblVolqueteC.Text = "Volquete Chico";
            lblVolqueteC.TextAlign = ContentAlignment.TopRight;
            lblVolqueteC.UseCompatibleTextRendering = true;
            // 
            // lblVolqueteG
            // 
            lblVolqueteG.Anchor = AnchorStyles.None;
            lblVolqueteG.AutoSize = true;
            lblVolqueteG.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblVolqueteG.ForeColor = Color.FromArgb(9, 111, 155);
            lblVolqueteG.Location = new Point(926, 241);
            lblVolqueteG.Name = "lblVolqueteG";
            lblVolqueteG.Size = new Size(167, 30);
            lblVolqueteG.TabIndex = 48;
            lblVolqueteG.Text = "Volquete Grande";
            lblVolqueteG.TextAlign = ContentAlignment.TopRight;
            lblVolqueteG.UseCompatibleTextRendering = true;
            // 
            // lblStockVC
            // 
            lblStockVC.Anchor = AnchorStyles.None;
            lblStockVC.AutoSize = true;
            lblStockVC.Font = new Font("Bahnschrift SemiCondensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVC.ForeColor = Color.FromArgb(9, 111, 155);
            lblStockVC.Location = new Point(169, 268);
            lblStockVC.Name = "lblStockVC";
            lblStockVC.Size = new Size(62, 23);
            lblStockVC.TabIndex = 49;
            lblStockVC.Text = "Stock: 0";
            lblStockVC.TextAlign = ContentAlignment.TopRight;
            lblStockVC.UseCompatibleTextRendering = true;
            // 
            // lblStockVM
            // 
            lblStockVM.Anchor = AnchorStyles.None;
            lblStockVM.AutoSize = true;
            lblStockVM.Font = new Font("Bahnschrift SemiCondensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVM.ForeColor = Color.FromArgb(9, 111, 155);
            lblStockVM.Location = new Point(584, 268);
            lblStockVM.Name = "lblStockVM";
            lblStockVM.Size = new Size(62, 23);
            lblStockVM.TabIndex = 50;
            lblStockVM.Text = "Stock: 0";
            lblStockVM.TextAlign = ContentAlignment.TopRight;
            lblStockVM.UseCompatibleTextRendering = true;
            // 
            // lblStockVG
            // 
            lblStockVG.Anchor = AnchorStyles.None;
            lblStockVG.AutoSize = true;
            lblStockVG.Font = new Font("Bahnschrift SemiCondensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblStockVG.ForeColor = Color.FromArgb(9, 111, 155);
            lblStockVG.Location = new Point(981, 268);
            lblStockVG.Name = "lblStockVG";
            lblStockVG.Size = new Size(62, 23);
            lblStockVG.TabIndex = 51;
            lblStockVG.Text = "Stock: 0";
            lblStockVG.TextAlign = ContentAlignment.TopRight;
            lblStockVG.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(189, 232, 250);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnSumarVG);
            groupBox1.Controls.Add(btnRestarVC);
            groupBox1.Controls.Add(btnSumarVM);
            groupBox1.Controls.Add(lblPrecioGrande);
            groupBox1.Controls.Add(btnSumarVC);
            groupBox1.Controls.Add(lblStockVG);
            groupBox1.Controls.Add(lblVolqueteC);
            groupBox1.Controls.Add(lblStockVC);
            groupBox1.Controls.Add(lblVolqueteM);
            groupBox1.Controls.Add(lblCantidadVolqueteChico);
            groupBox1.Controls.Add(lblCantidadVolqueteMediano);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(lblCantidadVolqueteGrande);
            groupBox1.Controls.Add(btnRestarVG);
            groupBox1.Controls.Add(lblPrecioMediano);
            groupBox1.Controls.Add(btnRestarVM);
            groupBox1.Controls.Add(lblPrecioChico);
            groupBox1.Controls.Add(lblStockVM);
            groupBox1.Controls.Add(lblVolqueteG);
            groupBox1.Location = new Point(63, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1199, 400);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 190, 240);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1321, 720);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(btnCarrito);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlquilarVolquetes";
            ((System.ComponentModel.ISupportInitialize)btnCarrito).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVG).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSumarVC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnAgregarAlCarrito;
        private ListBox lstProductos;
        private Button btnIngresar;
        private PictureBox btnCarrito;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox btnRestarVG;
        private PictureBox pictureBox3;
        private PictureBox btnRestarVM;
        private Label lblCantidadVolqueteChico;
        private PictureBox btnRestarVC;
        private Label lblCantidadVolqueteMediano;
        private PictureBox btnSumarVG;
        private Label lblCantidadVolqueteGrande;
        private PictureBox btnSumarVM;
        private Label lblPrecioChico;
        private PictureBox btnSumarVC;
        private Label lblPrecioMediano;
        private Label lblPrecioGrande;
        private PictureBox pictureBox2;
        private Label lblVolqueteM;
        private Label lblVolqueteC;
        private Label lblVolqueteG;
        private Label lblStockVC;
        private Label lblStockVM;
        private Label lblStockVG;
        private GroupBox groupBox1;
    }
}